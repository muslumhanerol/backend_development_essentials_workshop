using Microsoft.EntityFrameworkCore;
using project_third_efcoreApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//veritabanı bağlantısı.
//DataContext= DataContext.cs 7. satır.
builder.Services.AddDbContext<DataContext>(options =>
{
    var config = builder.Configuration; //Konfigürasyon ayarlandı.
    var ConnectionString = config.GetConnectionString("database"); //Konfigürasyon ettiğim ConnectionString adı "database".
    options.UseSqlite(ConnectionString); //UseSqlite veritabanında bu ConnectionStringe göre oluştur.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
