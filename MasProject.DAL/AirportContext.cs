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
            #region Primary Keys Constraints

            modelBuilder.Entity<PassengerReservation>()
                .HasKey(pr => new {pr.ReservationId, pr.PassengerId});

            #endregion

            #region Assoctiations

            modelBuilder.Entity<Person>()
                .HasOptional(p => p.Passenger)
                .WithRequired(ps => ps.Person);

            modelBuilder.Entity<Person>()
                .HasOptional(p => p.User)
                .WithRequired(ps => ps.Person);

            modelBuilder.Entity<Person>()
                .HasOptional(p => p.Staff)
                .WithRequired(ps => ps.Person);

            modelBuilder.Entity<User>()
                .HasMany(usr => usr.Reservations)
                .WithRequired(r => r.User);

            modelBuilder.Entity<PassengerReservation>()
                .HasRequired(pr => pr.Passenger)
                .WithMany(p => p.PassengerReservations)
                .HasForeignKey(pr => pr.PassengerId);

            modelBuilder.Entity<PassengerReservation>()
                .HasRequired(pr => pr.Reservation)
                .WithMany(p => p.PassengerReservations)
                .HasForeignKey(pr => pr.ReservationId);
            
            #endregion

            #region Unique Constraints

//            modelBuilder.Entity<IdentificationDocument>()
//                .HasIndex(doc => doc.DocumentNumber)
//                .IsUnique();

            #endregion
        }
    }
}