using System;
using MasProject.DAL.Models;

namespace MasProject.Extensions
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var reservation = new Reservation
            {
                DateOfReservation = DateTime.Now,
                UserId = 5, //DatabaseHelper.GetUsers().First(u => u.UserId==5)
                ReservationState = 0,
                FlightId = 1,
                ReservationType = ReservationType.VIP
            };
            // DatabaseHelper.AddOrUpdateReservation(reservation);
        }
    }
}