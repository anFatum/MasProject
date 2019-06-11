using MasProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MasProject.DAL
{
    public static class DatabaseHelper
    {

        public static void AddUser(User user)
        {
            using (var context = new AirportContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static User LoginUser(string email, string password)
        {
            User user;
            using (var context = new AirportContext())
            {
                user = context.Users
                    .Include(u => u.Reservations)
                    .Include(u => u.Person)
                    .Include(u => u.Person.Passenger)
                    .Include(u => u.Person.Passenger.IdentificationDocument)
                    .Include(u => u.Reservations.Select(r => r.Flight))
                    .Include(u => u.Reservations.Select(r => r.Passengers))
                    .Include(u => u.Reservations.Select(r => r.Passengers.Select(p => p.Person)))
                    .Include(u => u.Reservations.Select(r => r.Passengers.Select(p => p.IdentificationDocument)))
                    .FirstOrDefault(u => u.Email.ToLower().Equals(email.ToLower()));
                if (user == null)
                    throw new Exception("User not found");
                if (!user.Password.Equals(password))
                    throw new Exception("Invalid password");
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
                var reservations = GetReservationsForUser(user)
                    .Where(reservation => reservation.ReservationState == reservationState)
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
                    .Include(r => r.Passengers.Select(p => p.Person))
                    .Include(r => r.Passengers.Select(p => p.IdentificationDocument))
                    .ToList();
                return reservations;
            }
        }

        public static Reservation GetReservationById(int reservationId)
        {
            using (var context = new AirportContext())
            {
                return GetReservations().First(r => r.ReservationId == reservationId);
            }
        }

        public static ICollection<Passenger> GetPassengersForReservation(int reservationId)
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

        public static void UpdateUser(Person user, Passenger passenger)
        {
            using (var context = new AirportContext())
            {
                context.Passengers.Add(passenger);
                context.Persons.Attach(user);
                user.Passenger = passenger;
                context.SaveChanges();
            }
        }

        public static void AddOrUpdateReservation(Reservation reservation, User user)
        {
            using (var context = new AirportContext())
            {
                if (!context.Reservations.Any(r => r.ReservationId == reservation.ReservationId))
                {
                    var flight = reservation.Flight;
                    reservation.Flight = null;
                    context.Users.First(u => u.UserId == user.UserId).Reservations.Add(reservation);
                    context.Flights.First(f => f.FlightId == flight.FlightId).Reservations.Add(reservation);
                    user.Reservations.Add(reservation);
                }

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
    }
}