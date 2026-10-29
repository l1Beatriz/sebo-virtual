using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SeboDigital.Models;

public class Book
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O título é obrigatório.")]
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Isbn { get; set; } = string.Empty;
    [Required]
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
