using Microsoft.EntityFrameworkCore;

namespace project_third_efcoreApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Veri tabanı tablosu oluşturmak için setledik.
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<Kurs> Kurslar => Set<Kurs>();
        public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();

    }

}

//constructor= burası çağrıldığında ilk çalışacak şey.

// DataContext = constructor (DataContext = veri tabanıyla c# kodları arasındaki köprü<DataContext=fcore bağlantı ayarlarını barındıran sınıfın adı> options) : base =entity framework core üst sınıf tarafından çağrıldığında options olarak alabilirsiniz.(options)