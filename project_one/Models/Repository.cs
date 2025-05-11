namespace project_one.Models
{
    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamps = new();

        static Repository()
        {
            _bootcamps = new List<Bootcamp>(){
                 new Bootcamp(){id = 1, Title = "Backend Bootcamp", Description = "Güzel Başladı",Image="1.png", IsActive=false, IsHome=true},
                new Bootcamp(){id = 2, Title = "Game Bootcamp", Description = "Güzel Başladı",Image="2.png", IsActive=true, IsHome=true},
                new Bootcamp(){id = 3, Title = "React Bootcamp", Description = "Güzel Başladı",Image="3.jpg", IsActive=true, IsHome=true}
            };
        }
        public static List<Bootcamp> Bootcamps { get { return _bootcamps; } }

        //Detay sayfası için id kontrolu, id var mı yok mu. BootcampController tarafında çağırdık.
        public static Bootcamp? GetById(int? id)
        {
            return _bootcamps.FirstOrDefault(c => c.id == id);
        }

    }
}


// Veriyi tek bir yerden kontrol etmek için Repository kullanıyoruz.
// _bootcamps = new List<Bootcamp>(){ reposştory içerisi daha önceden BootcampController.cs içerisindeydi, ancak Repository kulanarak verileri buraya taşıdık ve Bootcampcontroller.cs de public IActionResult List() içerisini Repositoryi çağırarak kullandık, bir farklılık yok.