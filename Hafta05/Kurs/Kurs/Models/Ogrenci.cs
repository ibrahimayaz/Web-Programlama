namespace Kurs.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public String? Ad { get; set; } = String.Empty;
        public String? Soyad { get; set; } = String.Empty;
        public String? TamAd => $"{Ad} {Soyad?.ToUpper()}";
        public String? SecilenKurs { get; set; }
        public int Yas { get; set; }
        public DateTime BasvuruTarihi { get; set; }

        public Ogrenci()
        {
            BasvuruTarihi = DateTime.Now;
        }
    }
}
