using MasProject.DAL;
using MasProject.DAL.Models;

namespace MasProject.Extensions
{
    public static class ReservationExtension
    {
        public static void SetReservationType(this Reservation reservation, ReservationType type)
        {
            using (var context = new AirportContext())
            {
                reservation.ReservationType = type;
                context.SaveChanges();
            }
        }
    }
}