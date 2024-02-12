using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
namespace WebApplication4.Controllers;

public class HomeController(ILogger<HomeController> logger, QlbhContext context) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly QlbhContext _context = context;

    public IActionResult Index()
    {
        ViewModel viewModel = new()
        {
            TblCtdondhList = [.. _context.TblCtdondhs],
            TblCtyphapList = [.. _context.TblCtpnhaps],
            TblCtpxuatList = [.. _context.TblCtpxuats],
            TblDondhList = [.. _context.TblDondhs],
            TblNhaccList = [.._context.TblNhaccs],
            TblPxuatList = [.._context.TblPxuats],
            TblPnhapList = [.. _context.TblPnhaps],
            TblTonkhoList = [.._context.TblTonkhos],
            TblVattuList = [.. _context.TblVattus]
        };        return View(viewModel);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
