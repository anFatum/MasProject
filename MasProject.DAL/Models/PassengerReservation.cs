namespace MasProject.DAL.Models
{
    public class PassengerReservation
    {
        public int PassengerId { get; set; }
        public int ReservationId { get; set; }

        public virtual Passenger Passenger { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}