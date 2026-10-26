using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Data.Dtos;

public class CreateUserDto
{
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    private string Password { get; set; }
}
