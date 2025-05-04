using Microsoft.AspNetCore.Mvc;

namespace project_one.Controllers
{
    //Projede mvc controllerın özelliini kullanacağız dedik.
    public class BootcampController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}


//Bir Action oluşturduğumuzda ve dönüş olarak view döndürüldüğünde Actiom ın aynı adıyla view içerisine klasör oluştur sonra her action için cshtml dosyası olarak aç.Ör: index.cshtml, list.cshtml