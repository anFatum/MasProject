using System;
using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Luggage
    {
        private static double MaxWeight = 23;
        private double _weight;

        [Key] public int LuggageId { get; set; }

        [Required]
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > MaxWeight)
                    throw new ArgumentException($"Weight should be less or equals than {MaxWeight} kg!");
                _weight = value;
            }
        }

        [Required] public Dimension Dimension { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}