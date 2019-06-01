using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Pilot : Staff
    {
        [Required] public string Title { get; set; }
    }
}