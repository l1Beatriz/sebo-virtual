using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Models;

public class User
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    private string Password { get; set; }
}
