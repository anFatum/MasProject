using System;
using MasProject.DAL.Models;

namespace MasProject.DAL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
//            <!-- connectionString="Data Source=masproject.database.windows.net;Initial Catalog=MasProject;Persist Security Info=False;User ID=s15400;Password=qV8NuTHR;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" -->
//            using (var context = new AirportContext())
//            {
                DocumentType docType;
                Enum.TryParse("Internal Passport", out docType);
                var idDoc = new IdentificationDocument
                {
                    CountryOfIssuance = "Temp",
                    DocumentNumber = "123456",
                    DocumentType = docType,
                    ExpirationDate = new DateTime(2030, 10, 10),
                    PassportSeries = "ABC"
                };
                var documentId = DatabaseHelper.AddIdentificationDocument(idDoc);
                var person = new Person
                {
                    DateOfBirth = new DateTime(1998, 5,5),
                    FirstName = "Abby",
                    LastName = "Gail"
                };
                var personId = DatabaseHelper.AddPerson(person);
                var passengerId = DatabaseHelper.AddPassenger(documentId, personId);
//                DatabaseHelper.AddPassengerToReservation(_reservation.ReservationId, passengerId);
//                _reservation = DatabaseHelper.GetReservationById(_reservation.ReservationId);
//                _form.RefreshData();
//                Close();
//            }
        }
    }
}