using System;

namespace MasProject.GUI.Models
{
    class PassengerPersonModel
    {
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age => (int)(DateTime.Now.Subtract(DateOfBirth).TotalDays / 365);
        public string DocumentNumber { get; set; }
    }
}
