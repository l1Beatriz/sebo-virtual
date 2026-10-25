using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Models;

public class Evaluation
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public int Rating { get; set; } // 1 to 5
    public string Comment { get; set; }
}
