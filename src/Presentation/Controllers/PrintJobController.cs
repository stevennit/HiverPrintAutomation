using HiverPrintAutomation.Domain.Entities;
using HiverPrintAutomation.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HiverPrintAutomation.Web.Controllers;

public class PrintJobController : Controller
{
    private readonly IPrintJobRepository _printJobRepository;

    public PrintJobController(IPrintJobRepository printJobRepository)
    {
        _printJobRepository = printJobRepository;
    }

    public async Task<IActionResult> Index()
    {
        var jobs = await _printJobRepository.GetAllAsync();
        return View(jobs);
    }
}
