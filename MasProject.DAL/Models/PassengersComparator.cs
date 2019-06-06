using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProject.DAL.Models
{
    class PassengersComparator : IEqualityComparer<Passenger>
    {
        public bool Equals(Passenger x, Passenger y)
        {
            return x.IdentificationDocument.DocumentNumber.Equals(y.IdentificationDocument.DocumentNumber);
        }

        public int GetHashCode(Passenger obj)
        {
            return obj.IdentificationDocument.DocumentNumber.GetHashCode();
        }
    }
}
