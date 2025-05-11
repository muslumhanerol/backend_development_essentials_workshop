using Microsoft.AspNetCore.Mvc;
using project_one.Models;

namespace project_one.Controllers
{
    //Projede mvc controllerın özelliini kullanacağız dedik.
    public class BootcampController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Bootcamps.ToList());
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                //1.yol = return Redirect("/bootcamp/List");
                return RedirectToAction("List", "Bootcamp");
            }
            var bootcamp = Repository.GetById(id);
            return View(bootcamp);
        }
        public IActionResult List()
        {
            return View(Repository.Bootcamps.ToList());
        }
    }
}


//Bir Action oluşturduğumuzda ve dönüş olarak view döndürüldüğünde Actiom ın aynı adıyla view içerisine klasör oluştur sonra her action için cshtml dosyası olarak aç.Ör: index.cshtml, list.cshtml

//Index için = 11. satırlarda nesneyi oluşturduk ve özellikleri belirledik. Bu özellikleri view içerisine bootcamp yazarak gönderdim. Artık view içerisinde bu veriler kullanılabilir oldu.

//List için. = Burada liste halinde verileri tanımladık.

/////////////////////////////////////////////////
/// Repository kullanmakdançnceki hali.
// public IActionResult List()
// {
//     var bootcamp = new List<Bootcamp>(){
//                 new Bootcamp(){id = 1, Title = "Backend Bootcamp", Description = "Güzel Başladı",Image="1.png"},
//                 new Bootcamp(){id = 2, Title = "Game Bootcamp", Description = "Güzel Başladı",Image="2.png"},
//                 new Bootcamp(){id = 3, Title = "React Bootcamp", Description = "Güzel Başladı",Image="3.jpg"}
//             };
//     return View(bootcamp);
// }