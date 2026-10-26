using System.ComponentModel.DataAnnotations;

namespace SeboDigital.Data.Dtos;

public class ReadBookDto
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; } 
    public decimal Price { get; set; }
    public string Isbn { get; set; } = string.Empty;
}
