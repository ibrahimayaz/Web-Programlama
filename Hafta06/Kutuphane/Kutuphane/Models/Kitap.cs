using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı zorunludur.")]
        public String Ad { get; set; }
        [Required(ErrorMessage = "Yazar alanı zorunludur.")]
        public String Yazar { get; set; }
        public String? ImageUrl { get; set; }
    }
}
