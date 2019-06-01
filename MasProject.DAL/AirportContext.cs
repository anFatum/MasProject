using System.Data.Entity;
using MasProject.DAL.Models;

namespace MasProject.DAL
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base("AirportContext")
        {
            Database.SetInitializer<AirportContext>(new AirportInitializer());
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<IdentificationDocument> IdentificationDocuments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOptional(p => p.Passenger)
                .WithRequired(ps => ps.Person);
        }
    }
}