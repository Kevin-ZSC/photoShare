using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace photoShare.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}