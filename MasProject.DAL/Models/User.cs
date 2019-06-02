using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MasProject.DAL.Models
{
    public class User
    {
        public User()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key] [ForeignKey("Person")] public int UserId { get; set; }
        [Required] [MaxLength(64)] public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required] public string Password { get; set; }
        [Required] public DateTime DateOfRegistration { get; set; }
        public RegularCustomerCard RegularCustomerCard { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}