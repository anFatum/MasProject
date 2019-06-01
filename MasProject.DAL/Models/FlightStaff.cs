using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class FlightStaff
    {
        public int FlightId { get; set; }
        public int StaffId { get; set; }
        [Required] public string Role { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Staff Staff { get; set; }
    }
}