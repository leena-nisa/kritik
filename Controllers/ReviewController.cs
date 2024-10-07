using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kritik.Models;

namespace MVCProjFile.Controllers;

public class ReviewController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ReviewController(ILogger<HomeController> logger)
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
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit() //ALSO UPDATE IN HERE (?)
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }
    public IActionResult Read()
    {
        return View();
    }
}