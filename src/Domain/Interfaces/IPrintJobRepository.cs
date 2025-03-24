using HiverPrintAutomation.Domain.Entities;

namespace HiverPrintAutomation.Domain.Interfaces;

public interface IPrintJobRepository
{
    Task<List<PrintJob>> GetAllAsync();
    Task<PrintJob?> GetByIdAsync(int id);
    Task AddAsync(PrintJob job);
    Task DeleteAsync(int id);
}
