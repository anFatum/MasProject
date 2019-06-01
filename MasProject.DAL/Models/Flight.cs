using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Flight
    {
        [Key] public int FlightId { get; set; }
        [Required] public DateTime TimeOfFlight { get; set; }
        [Required] [MaxLength(16)] public string FlightNumber { get; set; }

        public virtual Airline Airline { get; set; }
        public virtual Airport DestinationAirport { get; set; }
        public virtual Airport OriginAirport { get; set; }
        public virtual Plane Plane { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<FlightStaff> FlightStaff { get; set; }
    }
}