using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kritik.Models;

namespace MVCProjFile.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountController(ILogger<HomeController> logger)
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

        //added
        public IActionResult CreateAccount() //ALSO SIGN UP (?)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public bool IsRegistered()
        {
            return true;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            return View();
        }

        public IActionResult DeleteProfile()
        {
            return View();
        }

        public string GetName()
        {
            return ""; 
        }

        public int GetUID()
        {
            return 0;  
        }

        public IActionResult GetReviewData()
        {
            return View();
        }
    }
}

