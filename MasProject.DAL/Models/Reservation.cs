using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public enum ReservationType
    {
        Usual,
        VIP,
        Urgent
    }

    public class Reservation
    {
        [Key] public int ReservationId { get; set; }
        public DateTime DateOfCancellation { get; set; }
        [Required] public DateTime DateOfReservation { get; set; }
        [Required] public double Price { get; set; }
        [Required] public ReservationType ReservationType { get; set; }
        
        public virtual User User { get; set; }
        
        public ICollection<PassengerReservation> PassengerReservations { get; set; }
        
    }
}