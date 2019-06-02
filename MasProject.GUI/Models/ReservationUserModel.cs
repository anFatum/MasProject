using System;
using MasProject.DAL.Models;

namespace MasProject.GUI.Models
{
    class ReservationUserModel
    {
        public string FlightNumber { get; set; }
        public DateTime DateOfReservation { get; set; }
        public ReservationType ReservationType { get; set; }
        public double Price { get; set; }
        public ReservationState ReservationState { get; set; }
    }
}
