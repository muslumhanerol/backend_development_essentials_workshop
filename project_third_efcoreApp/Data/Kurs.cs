namespace project_third_efcoreApp.Data
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string? Baslik { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
        //Kurs olarak kur kaydın içindeki Ogrenci bilgilerini getir.
    }
}