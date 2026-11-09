namespace SeboDigital.Data.Dtos;

public class ReadExchangeDto
{
    public DateOnly Date { get; set; }
    public string Status { get; set; } // "pending", "accepted", "rejected", "completed", "canceled"
}
