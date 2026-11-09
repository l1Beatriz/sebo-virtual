using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Models;

public class Exchange
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public DateOnly Date { get; set; }
    [Required]
    public string Status { get; set; } // "pending", "accepted", "rejected", "completed", "canceled"
}
