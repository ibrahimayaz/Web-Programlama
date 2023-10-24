using IlkDers.Models;
using Microsoft.AspNetCore.Mvc;

namespace IlkDers.Controllers
{
    public class BolumController:Controller
    {
        public IActionResult Liste()
        {
            var bolumListesi = new List<Bolum>
            {
                new Bolum()
                {
                    No=1,
                    Ad="Bilgisayar Teknolojileri",
                    Aciklama="Teknik Bilimler MYO"
                },
                new Bolum()
                {
                    No=1,
                    Ad="Bilgisayar Mühendisliği",
                    Aciklama="Mühendislik Fakültesi"
                }
            };
            return View(bolumListesi);
        }
    }
}
