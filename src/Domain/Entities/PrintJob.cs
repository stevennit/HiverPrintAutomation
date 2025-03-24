namespace HiverPrintAutomation.Domain.Entities;

public class PrintJob
{
    public int Id { get; set; }
    public string JobName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
