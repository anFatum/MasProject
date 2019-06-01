using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MasProject.DAL.Models
{
    public class User
    {
        [Key] [ForeignKey("Person")] public int UserId { get; set; }
        [Required] public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public RegularCustomerCard RegularCustomerCard { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}