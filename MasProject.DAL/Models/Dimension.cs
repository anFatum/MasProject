using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public class Dimension
    {
        [Key] public int DimensionId { get; set; }
        [Required] public double Height { get; set; }
        [Required] public double Length { get; set; }
        [Required] public double Width { get; set; }
    }
}