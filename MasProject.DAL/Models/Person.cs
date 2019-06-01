using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MasProject.DAL.Models
{
    public class Person
    {
        [Key] public int PersonId { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public int Age => (int) (DateTime.Now.Subtract(DateOfBirth).TotalDays / 365);
        public virtual Passenger Passenger { get; set; }
        public virtual User User { get; set; }
    }
}