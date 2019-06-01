using System;
using System.Data.Entity;
using MasProject.DAL.Models;

namespace MasProject.DAL
{
    public class AirportInitializer : DropCreateDatabaseIfModelChanges<AirportContext>
    {
        protected override void Seed(AirportContext context)
        {
            var id = new IdentificationDocument
            {
                DocumentNumber = "123456",
                DocumentType = DocumentType.InternalPassport,
                ExpirationDate = new DateTime(1999, 5, 12),
                CountryOfIssuance = "Spain"
            };
            context.IdentificationDocuments.Add(id);
            context.SaveChanges();
        }
    }
}