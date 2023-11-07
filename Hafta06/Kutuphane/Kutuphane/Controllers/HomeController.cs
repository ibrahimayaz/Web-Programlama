using Kutuphane.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kutuphane.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}