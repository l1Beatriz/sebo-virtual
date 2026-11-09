using SeboDigital.Models;

namespace SeboDigital.Data.Dtos;

public class ReadUserDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public ICollection<ReadBookDto> Books { get; set; }
    public ICollection<ReadEvaluationDto> Evaluations { get; set; }
}
