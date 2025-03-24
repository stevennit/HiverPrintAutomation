using HiverPrintAutomation.Domain.Entities;
using HiverPrintAutomation.Domain.Interfaces;
using HiverPrintAutomation.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HiverPrintAutomation.Infrastructure.Repositories;

public class PrintJobRepository : IPrintJobRepository
{
    private readonly AppDbContext _context;

    public PrintJobRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PrintJob>> GetAllAsync() => await _context.PrintJobs.ToListAsync();

    public async Task<PrintJob?> GetByIdAsync(int id) => await _context.PrintJobs.FindAsync(id);

    public async Task AddAsync(PrintJob job)
    {
        _context.PrintJobs.Add(job);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var job = await _context.PrintJobs.FindAsync(id);
        if (job != null)
        {
            _context.PrintJobs.Remove(job);
            await _context.SaveChangesAsync();
        }
    }
}
