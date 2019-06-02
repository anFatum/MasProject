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

        public virtual User User { get; set; }
        public virtual Flight Flight { get; set; }

        public virtual ICollection<PassengerReservation> PassengerReservations { get; set; }
        public virtual ICollection<Luggage> Luggage { get; set; }
    }
}