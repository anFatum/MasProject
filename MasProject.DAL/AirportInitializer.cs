using System;
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

            foreach (var person in testPeople.Generate(3))
            {
                var testUser = new Faker<User>()
                    .RuleFor(user => user.Person, person)
                    .RuleFor(user => user.Email, faker => faker.Internet.Email(person.FirstName, person.LastName))
                    .RuleFor(user => user.Password, faker => faker.Internet.Password())
                    .RuleFor(user => user.PhoneNumber, faker => faker.Phone.PhoneNumberFormat())
                    .Generate();
                context.Persons.Add(person);
                context.Users.Add(testUser);
                context.SaveChanges();
            }

            //===============
            var testDocs = new Faker<IdentificationDocument>()
                .RuleFor(id => id.DocumentType, f => f.PickRandom<DocumentType>())
                .RuleFor(id => id.CountryOfIssuance, f => f.Address.Country())
                .RuleFor(id => id.ExpirationDate,
                    f => f.Date.Future(20, f.Date.Between(new DateTime(1990, 1, 1),
                        new DateTime(2000, 1, 1)))
                        .Date)
                .RuleFor(id => id.DocumentNumber, f => f.Random.Replace("########"));
            testDocs.Generate(5).ToList().ForEach(id => context.IdentificationDocuments.Add(id));
            context.SaveChanges();
        }
    }
}