using System.Data.Entity;
using MasProject.DAL.Models;

namespace MasProject.DAL
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base("AirportContext")
        {
            Database.SetInitializer(new AirportInitializer());
        }


        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<CheckInStaff> CheckInStaff { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightStaff> FlightStaff { get; set; }
        public DbSet<IdentificationDocument> IdentificationDocuments { get; set; }
        public DbSet<Luggage> Luggage { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<PassengerReservation> PassengerReservations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<RegularCustomerCard> RegularCustomerCards { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Stewardess> Stewardesses { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Primary Keys Constraints

            modelBuilder.Entity<PassengerReservation>()
                .HasKey(pr => new {pr.ReservationId, pr.PassengerId});
            modelBuilder.Entity<FlightStaff>()
                .HasKey(staff => new {staff.FlightId, staff.StaffId});

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

            modelBuilder.Entity<PassengerReservation>()
                .HasRequired(pr => pr.Passenger)
                .WithMany(p => p.PassengerReservations)
                .HasForeignKey(pr => pr.PassengerId);

            modelBuilder.Entity<PassengerReservation>()
                .HasRequired(pr => pr.Reservation)
                .WithMany(p => p.PassengerReservations)
                .HasForeignKey(pr => pr.ReservationId);

            modelBuilder.Entity<Reservation>()
                .HasMany(r => r.Luggage)
                .WithRequired(l => l.Reservation);

            modelBuilder.Entity<Flight>()
                .HasRequired(flight => flight.Airline)
                .WithMany(airline => airline.Flights);

            modelBuilder.Entity<Flight>()
                .HasRequired(flight => flight.Plane)
                .WithMany(plane => plane.Flights);

            modelBuilder.Entity<Reservation>()
                .HasRequired(reservation => reservation.Flight)
                .WithMany(flight => flight.Reservations);

            modelBuilder.Entity<Reservation>()
                .HasRequired(reservation => reservation.User)
                .WithMany(user => user.Reservations);

            modelBuilder.Entity<FlightStaff>()
                .HasRequired(flightStaff => flightStaff.Flight)
                .WithMany(flight => flight.FlightStaff)
                .HasForeignKey(staff => staff.FlightId);

            modelBuilder.Entity<FlightStaff>()
                .HasRequired(flightStaff => flightStaff.Staff)
                .WithMany(staff => staff.FlightStaff)
                .HasForeignKey(staff => staff.StaffId);

            #endregion

            #region Unique Constraints

            modelBuilder.Entity<User>()
                .HasIndex(user => user.Email)
                .IsUnique();

            modelBuilder.Entity<IdentificationDocument>()
                .HasIndex(doc => doc.DocumentNumber)
                .IsUnique();

            modelBuilder.Entity<RegularCustomerCard>()
                .HasIndex(card => card.CardNumber)
                .IsUnique();

            modelBuilder.Entity<Staff>()
                .HasIndex(staff => staff.EmployeeId)
                .IsUnique();

            #endregion
        }
    }
}