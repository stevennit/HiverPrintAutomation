using HiverPrintAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HiverPrintAutomation.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<PrintJob> PrintJobs { get; set; }
}
