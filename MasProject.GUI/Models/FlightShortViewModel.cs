using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProject.GUI.Models
{
    class FlightShortViewModel
    {
            public DateTime TimeOfFlight { get; set; }
            public string FlightNumber { get; set; }
            public string Airline { get; set; }
            public string DestinationAirport { get; set; }
            public string OriginAirport { get; set; }
    
    }
}
