using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment1_Enterprise_MVC.Models;

namespace Assignment1_Enterprise_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
    
    [HttpGet("RequestForm")]
    public IActionResult RequestForm() => View();

    [HttpPost("RequestForm")]
    public IActionResult RequestForm(EquipmentRequest request)
    {
        if (!ModelState.IsValid)
            return View(request);

        Repository.AddRequest(request);
        return RedirectToAction("Confirmation");
    }

    [HttpGet("Confirmation")]
    public IActionResult Confirmation() => View();
    
    [HttpGet("AllEquipment")]
    public IActionResult AllEquipment()
    {
        ViewBag.Heading = "All Equipment";
        return View("EquipmentList", Repository.AllEquipment);
    }

    [HttpGet("AvailableEquipment")]
    public IActionResult AvailableEquipment()
    {
        ViewBag.Heading = "Available Equipment";
        return View("EquipmentList", Repository.AvailableEquipment);
    }
    
    
}