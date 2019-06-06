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

    public enum ReservationState
    {
        InProgress,
        WaitingForPayment,
        Cancelled,
        Refunded,
        Done,
        WaitingForRefund,
        WaitingForFlight
    }

    public class Reservation
    {
        [Key] public int ReservationId { get; set; }
        public DateTime? DateOfCancellation { get; set; }
        [Required] public DateTime DateOfReservation { get; set; }
        [Required] public double Price { get; set; }
        [Required] public ReservationType ReservationType { get; set; }
        [Required] public ReservationState ReservationState { get; set; }

        public int UserId { get; set; }
        public int FlightId { get; set; }

        public User User { get; set; }
        public Flight Flight { get; set; }

        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual ICollection<Luggage> Luggage { get; set; }
    }
}