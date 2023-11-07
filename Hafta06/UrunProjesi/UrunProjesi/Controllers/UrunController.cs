using Microsoft.AspNetCore.Mvc;
using UrunProjesi.Models;

namespace UrunProjesi.Controllers
{
    public class UrunController:Controller
    {
        public static List<Urun> urunListesi = new();
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Urun u)
        {
            if (ModelState.IsValid)
            {
                urunListesi.Add(u);
                return View("Liste", urunListesi);
            }
            else
            {
                return View(u);
            }
          
        }

        public IActionResult Liste()
        {
            return View(urunListesi);
        }
    }
}
