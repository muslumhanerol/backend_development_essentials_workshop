# Proje kurulumu: dotnet new mvc -o project_third_efcoreApp
# Proje Başlatma: dotnet watch run

# veritabanı bağlantı seçenekleri: https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli
# sql Lite Kurulumu: dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.5
# for migration website = https://learn.microsoft.com/en-us/ef/core/cli/dotnet
# for migration = dotnet tool install --global dotnet-ef
# for migration design = dotnet add package Microsoft.EntityFrameworkCore.Design
# create migration = dotnet ef migrations add InitialCreate
# how to see database = dotnet ef database update
# son migrationu geri alma = dotnet ef migrations remove


# dbContext = Uygulama ile veri tabanı arasındaki bağlantıyı sağlar.



# 1. Data klasörü oluşturuldu.
# 2. Data klasörü içerisinde Ogrenci.cs ve Kurs.cs oluşturulup içleri dolduruldu.
# 3. Data klasörü içerisinde KursKayit.cs oluşturuldu, ilişkisel veritabanı için.
# 4. dbContext için Data klasörü içerisinde DataContext.cs oluşturdum.


