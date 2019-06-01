using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class RegularCustomerCard
    {
        [Key] public int CardId { get; set; }
        [Required] public double Discount { get; set; }
        [Required][MaxLength(16)] public string CardNumber { get; set; }
    }
}