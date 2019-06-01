using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasProject.DAL.Models
{
    public class Passenger
    {
        [Key] [ForeignKey("Person")] public int PassengerId { get; set; }
        [Required] public IdentificationDocument IdentificationDocument { get; set; }
        public virtual Person Person { get; set; }
    }
}