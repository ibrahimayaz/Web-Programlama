using Kutuphane.Models;
using Kutuphane.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kutuphane.Controllers
{
    public class OgrenciController:Controller
    {
        public static List<Ogrenci> ogrenciListesi = new();
        public IActionResult Ekle()
        {
            OduncVM o = new OduncVM()
            {
                kitaplar = ViewData["KitapListesi"] as List<Kitap>
            };
            return View(o);
        }

        [HttpPost]
        public IActionResult Ekle(OduncVM o)
        {
            if (ModelState.IsValid)
            {
                ogrenciListesi.Add(o.ogrenci);
                return View("Liste", ogrenciListesi);
            }
            return View(o);
        }

        public IActionResult Liste()
        {
            return View(ogrenciListesi);
        }
        
    }
}
