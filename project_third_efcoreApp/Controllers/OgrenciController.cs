using Microsoft.AspNetCore.Mvc;
using project_third_efcoreApp.Data;

namespace project_third_efcoreApp.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly DataContext _context;

        public OgrenciController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model)
        {
            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

//readonly = Değişkenin sadece tanımlandığı yerde veya constructor içerisinde sadece bir kez atanabildiğini gösteriyor.