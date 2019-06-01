using System;

namespace MasProject.DAL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
//            <!-- connectionString="Data Source=masproject.database.windows.net;Initial Catalog=MasProject;Persist Security Info=False;User ID=s15400;Password=qV8NuTHR;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" -->
            using (var context = new AirportContext())
            {
                foreach (var idDoc in context.IdentificationDocuments)
                {
                    Console.Out.WriteLine(idDoc.DocumentNumber);
                }
            }
        }
    }
}