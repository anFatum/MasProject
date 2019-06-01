using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Technician : Staff
    {
        [Required] public string WorkArea { get; set; }
    }
}