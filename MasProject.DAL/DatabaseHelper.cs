﻿using MasProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProject.DAL
{
    public static class DatabaseHelper
    {
        public static User LoginUser(string email, string password)
        {
            User user;
            using (var context = new AirportContext())
            {
                user = context.Users.Where(u => u.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
                if (user == null)
                    throw new Exception("User not found");
                if (!user.Password.Equals(password))
                    throw new Exception("Invalid password");
                context.Entry(user).Reference(u => u.Person).Load();
                context.Entry(user).Collection(u => u.Reservations).Load();
            }
            return user;
        }

        public static ICollection<Reservation> GetReservationsForUser(User user){    
            using(var context = new AirportContext())
            {
                var reservations = context.Reservations.Where(reservation => reservation.User.UserId == user.UserId).ToList();
                return reservations;
            }
        }
    }
}