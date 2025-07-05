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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ogr = await _context.Ogrenciler.FirstOrDefaultAsync(o => o.OgrenciId == id);
            if (ogr == null)
            {
                return NotFound();
            }
            return View(ogr);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Güvenlik önlemi. Sistem sadece bizim oluşturduğumuz formdan gelen istekleri kabul eder. Eş zamanlı olarak iki farklı tokendan gelen veriyi kabul etmez.
        public async Task<IActionResult> Edit(int id, Ogrenci model)
        {
            if (id != model.OgrenciId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model); //context üzerinden update işlemini yap modeldeki verileri al.
                    await _context.SaveChangesAsync();//Herhangi bir sorun yoksa işlemi yap.
                }
                catch (DbUpdateConcurrencyException) //Aynı anda farklı tokenlar gelirse
                {

                    if (_context.Ogrenciler.Any(o => o.OgrenciId == model.OgrenciId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index"); //Sorunsuz güncellendiyse
            }
            return View(model); //Herhangi bir hata varsa
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ogrenci = await _context.Ogrenciler.FindAsync(id); //Ogrenci varlığı kontrolü
            if (ogrenci == null)
            {
                return NotFound();
            }
            return View(ogrenci);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        //int id = Delete.cshtml 6.satır name
        {
            var ogrenci = await _context.Ogrenciler.FindAsync(id); //Ogrenci varlığı kontrolü
            if (ogrenci == null)
            {
                return NotFound();
            }
            _context.Ogrenciler.Remove(ogrenci); //gelen öğrenci bilgisini sil.
            await _context.SaveChangesAsync(); //sonra context üzerine kaydet.
            return RedirectToAction("Index");

        }
    }
}

//readonly = Değişkenin sadece tanımlandığı yerde veya constructor içerisinde sadece bir kez atanabildiğini gösteriyor.