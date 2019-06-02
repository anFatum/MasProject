using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Bogus;
using MasProject.DAL.Models;
using Person = MasProject.DAL.Models.Person;

namespace MasProject.DAL
{
    public class AirportInitializer : DropCreateDatabaseIfModelChanges<AirportContext>
    {
        protected override void Seed(AirportContext context)
        {
            var testPeople = new Faker<Person>()
                .RuleFor(person => person.FirstName, faker => faker.Name.FirstName())
                .RuleFor(person => person.LastName, faker => faker.Name.LastName())
                .RuleFor(person => person.DateOfBirth,
                    faker => faker.Date.Between(new DateTime(1990, 1, 1),
                            new DateTime(2000, 1, 1))
                        .Date);

            var testDocs = new Faker<IdentificationDocument>()
                .RuleFor(id => id.DocumentType, f => f.PickRandom<DocumentType>())
                .RuleFor(id => id.CountryOfIssuance, f => f.Address.Country())
                .RuleFor(id => id.ExpirationDate,
                    f => f.Date.Future(20, f.Date.Between(new DateTime(2020, 1, 1),
                            new DateTime(2025, 1, 1)))
                        .Date)
                .RuleFor(id => id.DocumentNumber, f => f.Random.Replace("########"));
            testDocs.Generate(5).ToList().ForEach(id => context.IdentificationDocuments.Add(id));
            context.SaveChanges();

            foreach (var person in testPeople.Generate(4))
            {
                context.Persons.Add(person);
                context.SaveChanges();
                var passenger = new Passenger()
                {
                    Person = person,
                    IdentificationDocument = context.IdentificationDocuments.First(document =>
                        document.IdentificationDocumentId == person.PersonId)
                };
                context.Passengers.Add(passenger);
                context.SaveChanges();
            }

            foreach (var person in testPeople.Generate(3))
            {
                var testUser = new Faker<User>()
                    .RuleFor(user => user.Person, person)
                    .RuleFor(user => user.Email, faker => faker.Internet.Email(person.FirstName, person.LastName))
                    .RuleFor(user => user.Password, faker => faker.Internet.Password())
                    .RuleFor(user => user.PhoneNumber, faker => faker.Phone.PhoneNumberFormat())
                    .RuleFor(user => user.DateOfRegistration, faker => faker.Date.Past(2))
                    .Generate();
                context.Users.Add(testUser);
                context.SaveChanges();
            }

            var testAirlines = new Faker<Airline>()
                .RuleFor(airline => airline.Name, faker => faker.Company.CompanyName())
                .RuleFor(a => a.CountryOfOrigin, faker => faker.Address.Country())
                .RuleFor(airline => airline.DateOfCreation, faker => faker.Date.Between(new DateTime(1990, 1, 1),
                    new DateTime(2000, 1, 1)));
            testAirlines.Generate(5).ToList().ForEach(c => context.Airlines.Add(c));
            context.SaveChanges();

            var testAirports = new Faker<Airport>()
                .RuleFor(airport => airport.Name, faker => faker.Company.CompanyName())
                .RuleFor(airport => airport.Location, faker => faker.Address.Country());

            testAirports.Generate(6).ToList().ForEach(airport => context.Airports.Add(airport));
            context.SaveChanges();

            var testPlanes = new Faker<Plane>()
                .RuleFor(plane => plane.Model, "Airbus")
                .RuleFor(plane => plane.NumberOfSeats, faker => faker.Random.Int(160, 320));

            testPlanes.Generate(5).ForEach(plane => context.Planes.Add(plane));
            context.SaveChanges();

            var flight = new Flight()
            {
                Airline =
                    context.Airlines.OrderBy(r => Guid.NewGuid()).Skip(new Randomizer().Int(0, 4)).Take(1).First(),
                DestinationAirport = context.Airports.OrderBy(r => Guid.NewGuid()).Skip(new Randomizer().Int(0, 5))
                    .Take(1).First(),
                FlightNumber = new Bogus.Randomizer().Replace("???####"),
                TimeOfFlight = new Faker().Date.Future(1),
                Plane = context.Planes.OrderBy(r => Guid.NewGuid()).Skip(new Randomizer().Int(0, 4)).Take(1).First()
            };

            flight.OriginAirport =
                context.Airports.FirstOrDefault(airport => airport.AirportId != flight.DestinationAirport.AirportId);
            context.Flights.Add(flight);
            context.SaveChanges();

            foreach (var user in context.Users.Take(2).ToList())
            {
                var testReservation = new Faker<Reservation>()
                    .RuleFor(reservation => reservation.DateOfReservation, faker => faker.Date.Between(
                        user.DateOfRegistration,
                        flight.TimeOfFlight))
                    .RuleFor(reservation => reservation.Price, faker => Double.Parse(faker.Commerce.Price()))
                    .RuleFor(reservation => reservation.ReservationType, faker => faker.PickRandom<ReservationType>())
                    .RuleFor(reservation => reservation.ReservationState, ReservationState.WaitingForFlight)
                    .RuleFor(reservation => reservation.Flight, flight)
                    .RuleFor(reservation => reservation.User, user)
                    .Generate();
                context.Reservations.Add(testReservation);
                user.Reservations.Add(testReservation);
                flight.Reservations.Add(testReservation);
                context.SaveChanges();
            }
        }
    }
}