using HiverPrintAutomation.Domain.Interfaces;
using HiverPrintAutomation.Infrastructure.Persistence;
using HiverPrintAutomation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=.;Database=HiverPrintDB;Trusted_Connection=True;TrustServerCertificate=True"));
builder.Services.AddScoped<IPrintJobRepository, PrintJobRepository>();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PrintJob}/{action=Index}/{id?}"
);

app.Run();
