using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kritik.Models;

namespace MVCProjFile.Controllers;

public class MovieController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public MovieController(ILogger<HomeController> logger)
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

    //new
    public IActionResult Search()
    {
        return View();
    }


    public IActionResult Details()
    {
        return View();
    }


}
