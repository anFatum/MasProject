using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasProject.DAL.Models
{
    public abstract class Staff
    {
        [Key] [ForeignKey("Person")] public int StaffId { get; set; }
        [Required] public DateTime DateOfEmployment { get; set; }
        [Required] [MaxLength(16)] public string EmployeeId { get; set; }
        public TimeSpan ProbationPeriod => DateTime.Now.Subtract(DateOfEmployment);
        [Required] public virtual Person Person { get; set; }
        public virtual ICollection<FlightStaff> FlightStaff { get; set; }
    }
}