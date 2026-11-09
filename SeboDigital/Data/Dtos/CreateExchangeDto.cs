namespace SeboDigital.Data.Dtos;

public class CreateExchangeDto
{
    public DateOnly Date { get; set; }
    public string Status { get; set; } // "pending", "accepted", "rejected", "completed", "canceled"
}
