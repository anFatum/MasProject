using MasProject.DAL.Models;

namespace MasProject.Extensions
{
    public static class ReservationExtension
    {
        public static void SetPrice(this Reservation reservation)
        {
                var price = reservation.Flight == null ? 0.0 : 1505.0;
                price += reservation.Passengers.Count * 215.0;
                price += reservation.Luggage.Count * 105.5;
                reservation.Price = price;
        }
    }
}