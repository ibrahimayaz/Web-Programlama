using System.ComponentModel.DataAnnotations;

namespace UrunProjesi.Models
{
    public class Urun
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="Ad alanı zorunludur.")]
        public string Ad { get; set; }=String.Empty;

        [Required(ErrorMessage = "Fiyat alanı zorunludur.")]
        public double Fiyat { get; set; }
        public string? ImageUrl { get; set; } = String.Empty;
        public bool BoykotDurumu { get; set; }
    }
}
