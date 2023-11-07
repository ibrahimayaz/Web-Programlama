using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UrunProjesi.Models;

namespace UrunProjesi.Controllers
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