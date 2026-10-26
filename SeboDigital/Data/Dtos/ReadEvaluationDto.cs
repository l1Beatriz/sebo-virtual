using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Models;

public class ReadEvaluationDto
{
    [Required]
    public int Rating { get; set; } // 1 to 5
    public string Comment { get; set; }
}
