using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public async Task<IActionResult> Index()
        {
            return View(await _context.Ogrenciler.ToListAsync());
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
            return RedirectToAction("Index");
        }
    }
}

//readonly = Değişkenin sadece tanımlandığı yerde veya constructor içerisinde sadece bir kez atanabildiğini gösteriyor.