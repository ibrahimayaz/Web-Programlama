using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Ogrenci
    {
        [Required(ErrorMessage ="Öğrenci No zorunludur.")]
        public String No { get; set; }
        [Required(ErrorMessage = "{0} zorunludur.")]
        public String Ad { get; set; }

        [Required(ErrorMessage = "{0} zorunludur.")]
        public String Soyad { get; set; }

        public String TamAd => $"{Ad} {Soyad}";

        public String SecilenKitap { get; set; }
    }
}
