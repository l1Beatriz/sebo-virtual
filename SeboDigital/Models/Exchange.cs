namespace SeboDigital.Models;

public class Exchange
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string Status { get; set; } // "pending", "accepted", "rejected", "completed", "canceled"
}
