using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasProject.DAL.Models
{
    public class Staff
    {
        [Key] [ForeignKey("Person")] public int StaffId { get; set; }
        [Required] public DateTime DateOfEmployment { get; set; }
        [Required] public string EmployeeId { get; set; }
        public TimeSpan ProbationPeriod => DateTime.Now.Subtract(DateOfEmployment);
        [Required]
        public virtual Person Person { get; set; }
    }
}