using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasProject.DAL.Models
{
    public class Passenger
    {
        [Key] [ForeignKey("Person")] public int PassengerId { get; set; }
        [Required] public IdentificationDocument IdentificationDocument { get; set; }
        [Required] public virtual Person Person { get; set; }
        
        public ICollection<PassengerReservation> PassengerReservations { get; set; }
    }
}