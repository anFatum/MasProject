using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Stewardess : Staff
    {
        [Required] public string Title { get; set; }
    }
}