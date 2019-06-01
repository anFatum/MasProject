using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Airline
    {
        [Key] public int AirlineId { get; set; }
        [Required] public string CountryOfOrigin { get; set; }
        [Required] public DateTime DateOfCreation { get; set; }
        [Required] public string Name { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}