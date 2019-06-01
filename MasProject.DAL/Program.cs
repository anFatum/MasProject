using System;

namespace MasProject.DAL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
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