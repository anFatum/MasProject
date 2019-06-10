using System.Linq;
using MasProject.DAL;
using MasProject.DAL.Models;

namespace MasProject.Extensions
{
    public static class ReservationExtension
    {
        public static void SetType(this Reservation reservation, ReservationType type)
        {
//            using (var context = new AirportContext())
//            {
                reservation.ReservationType = type;
//                context.Reservations.First(r => r.ReservationId == reservation.ReservationId)
//                    .ReservationType = type;
//                context.SaveChanges();
//            }
        }

        public static void SetState(this Reservation reservation, ReservationState state)
        {
//            using (var context = new AirportContext())
//            {
                reservation.ReservationState = state;
//                context.Reservations.First(r => r.ReservationId == reservation.ReservationId)
//                    .ReservationState = state;
//                context.SaveChanges();
//            }
        }

        public static void SetPrice(this Reservation reservation)
        {
//            using (var context = new AirportContext())
//            {
//                var updateReservation =
//                    context.Reservations.FirstOrDefault(r => r.ReservationId == reservation.ReservationId);
                var price = reservation.FlightId == 0 ? 0.0 : 1505.0;
                price += reservation.Passengers.Count * 215.0;
                price += reservation.Luggage.Count * 105.5;
                reservation.Price = price;
               // reservation.Price = price;
//                context.SaveChanges();
//            }
        }
    }
}