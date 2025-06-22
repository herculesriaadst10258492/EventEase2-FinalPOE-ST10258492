using Microsoft.AspNetCore.Mvc;
using EventEase2.Models;
using EventEase2.Data;

namespace EventEase2.Controllers
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
