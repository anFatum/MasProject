using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasProject.DAL.Models
{
    public class Airport
    {
        [Key] public int AirportId { get; set; }
        [Required] public string Location { get; set; }
        [Required] public string Name { get; set; }

        [InverseProperty("OriginAirport")] 
        public virtual ICollection<Flight> FlightsOrigin { get; set; }

        [InverseProperty("DestinationAirport")]
        public virtual ICollection<Flight> FlightsDestination { get; set; }
    }
}