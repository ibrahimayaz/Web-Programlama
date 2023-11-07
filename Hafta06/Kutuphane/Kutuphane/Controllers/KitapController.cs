using Kutuphane.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kutuphane.Controllers
{
    public class KitapController:Controller
    {
        public static List<Kitap> kitapListesi = new();
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kitap k)
        {
            if (ModelState.IsValid)
            {
                kitapListesi.Add(k);
                ViewData["KitapListesi"] = kitapListesi;
                return View("Liste",kitapListesi);
            }
            return View(k);
        }

        public IActionResult Liste()
        {
            return View(kitapListesi);
        }
        
    }
}
