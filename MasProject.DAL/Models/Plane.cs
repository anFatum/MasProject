using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Plane
    {
        [Key] public int PlaneId { get; set; }
        [Required] public string Model { get; set; }
        [Required] public int NumberOfSeats { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}