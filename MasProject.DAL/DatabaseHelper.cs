using MasProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MasProject.DAL
{
    public static class DatabaseHelper
    {
        public static User LoginUser(string email, string password)
        {
            User user;
            using (var context = new AirportContext())
            {
                user = context.Users.Where(u => u.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
                if (user == null)
                    throw new Exception("User not found");
                if (!user.Password.Equals(password))
                    throw new Exception("Invalid password");
                context.Entry(user).Reference(u => u.Person).Load();
                context.Entry(user).Collection(u => u.Reservations).Load();
            }

            return user;
        }

        public static ICollection<Reservation> GetReservationsForUser(User user)
        {
            using (var context = new AirportContext())
            {
                var reservations = context.Reservations.Where(reservation => reservation.User.UserId == user.UserId)
                    .ToList();
                reservations.ForEach(reservation => { context.Entry(reservation).Reference(r => r.Flight).Load(); });
                return reservations;
            }
        }

        public static ICollection<User> GetUsers()
        {
            using (var context = new AirportContext())
            {
                var users = context.Users.Include(u => u.Person)
                    .Include(u => u.Reservations)
                    .Include(u => u.RegularCustomerCard)
                    .ToList();
                return users;
            }
        }

        public static ICollection<Reservation> GetReservationsForUserWithState(User user,
            ReservationState reservationState)
        {
            using (var context = new AirportContext())
            {
                var reservations = GetReservationsForUser(user).Where(reservation => reservation.ReservationState == reservationState)
                    .ToList();
                return reservations;
            }
        }

        public static ICollection<Flight> GetFlights()
        {
            using (var context = new AirportContext())
            {
                var flights = context.Flights
                    .Include(f => f.Airline)
                    .Include(f => f.DestinationAirport)
                    .Include(f => f.OriginAirport)
                    .Include(f => f.Plane)
                    .Include(f => f.Reservations)
                    .ToList();
                return flights;
            }
        }

        public static Flight GetFlightByNumber(string flightNumber)
        {
            using (var context = new AirportContext())
            {
                var searchFlight = GetFlights()
                    .First(flight => flight.FlightNumber.Equals(flightNumber));
                return searchFlight;
            }
        }

        public static ICollection<Reservation> GetReservations()
        {
            using (var context = new AirportContext())
            {
                var reservations = context.Reservations
                    .Include(r => r.Flight)
                    .Include(r => r.User)
                    .Include(r => r.Luggage)
                    .Include(r => r.Passengers)
                    .ToList();
                return reservations;
            }
        }

        public static void UpdatePrice(int reservationId, double price)
        {
            using (var context = new AirportContext())
            {
                var reservations = context.Reservations
                    .First(r => r.ReservationId == reservationId);
                reservations.Price = price;
                context.SaveChanges();
            }
        }

        public static Reservation GetReservationById(int reservationId)
        {
            using (var context = new AirportContext())
            {
                return GetReservations().First(r => r.ReservationId == reservationId);
            }
        }

        public static ICollection<Passenger> GetPassangersForReservation(int reservationId)
        {
            using (var context = new AirportContext())
            {
                var passengers = context.Reservations
                    .First(r => r.ReservationId == reservationId)
                    .Passengers.Select(p => p.PassengerId)
                    .ToList();
                var passengersToReturn = context.Passengers.Include(p => p.Person)
                    .Include(p => p.IdentificationDocument)
                    .Where(p => passengers.Contains(p.PassengerId)).ToList();
                return passengersToReturn;
            }
        }

        public static void AddOrUpdateReservation(Reservation reservation)
        {
            using (var context = new AirportContext())
            {
                if (context.Entry(reservation).State == EntityState.Detached)
                {
                    context.Reservations.Add(reservation);
                }

                context.SaveChanges();
                reservation.User = GetUsers().First(u => u.UserId == reservation.UserId);
                reservation.Flight = GetFlights().First(f => f.FlightId == reservation.FlightId);
            }
        }

        public static int AddIdentificationDocument(IdentificationDocument document)
        {
            using (var context = new AirportContext())
            {
                context.IdentificationDocuments.Add(document);
                context.SaveChanges();
            }

            return document.IdentificationDocumentId;
        }

        public static int AddPerson(Person person)
        {
            using (var context = new AirportContext())
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }

            return person.PersonId;
        }

        public static int AddPassenger(int documentId, int personId)
        {
            Passenger passenger;
            using (var context = new AirportContext())
            {
                var identificationDoc =
                    context.IdentificationDocuments.First(id => id.IdentificationDocumentId == documentId);
                var person =
                    context.Persons.First(pers => pers.PersonId == personId);
                passenger = new Passenger
                {
                    IdentificationDocument = identificationDoc,
                    Person = person
                };
                context.Passengers.Add(passenger);
                context.SaveChanges();
            }

            return passenger.PassengerId;
        }

        public static void AddPassengerToReservation(int reservationId, int passengerId)
        {
            using (var context = new AirportContext())
            {
                var passenger = context.Passengers
                    .Include(p => p.Person)
                    .Include(p => p.IdentificationDocument)
                    .First(p => p.PassengerId == passengerId);

                context.Reservations.First(r => r.ReservationId == reservationId)
                    .Passengers.Add(passenger);
                context.SaveChanges();
            }
        }

        public static bool DeleteReservation(Reservation reservation)
        {
            using (var context = new AirportContext())
            {
                try
                {
                    var entry = context.Entry(reservation);
                    entry.State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static void SetStateToReservation(int reservationId, ReservationState state)
        {
            using (var context = new AirportContext())
            {
                context.Reservations
                    .FirstOrDefault(r => r.ReservationId == reservationId)
                    .ReservationState = state;
                context.SaveChanges();
            }
        }
    }
}