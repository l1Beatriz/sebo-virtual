using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Models;

public class Evaluation
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [Range(1, 5, ErrorMessage = "The rating must be between 1 and 5.")]
    public int Rating { get; set; }
    [MaxLength(1000, ErrorMessage = "The comment cannot exceed 1,000 characters.")]
    public string Comment { get; set; } = string.Empty;
    public int UserId { get; set; }
    public int BookId { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }
}
