using System.ComponentModel.DataAnnotations;

namespace project_third_efcoreApp.Data
{
    public class Ogrenci
    {
        [Key] //OgrenciId yi birincil anahtar olarak al dedim.
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string Adsoyad { get { return this.OgrenciAd + " " + this.OgrenciSoyad; } }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

    }
}