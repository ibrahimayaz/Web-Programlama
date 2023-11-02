using Kurs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurs.Controllers
{
    public class OgrenciController : Controller
    {
      public static List<Ogrenci> ogrenciListesi=new();

        [HttpGet]
        public IActionResult Basvuru()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Basvuru(Ogrenci o)
        {
            ogrenciListesi.Add(o);
            return View("Liste", ogrenciListesi);
        }

        public IActionResult Liste()
        {
            return View(ogrenciListesi);
        }
    }
}
