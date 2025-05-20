using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using project_second_formsApp.Models;

namespace project_second_formsApp.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    public IActionResult Index(string searchString, string category)
    {
        //ürün listeleme
        var products = Repository.Products;
        if (!String.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString; //Veriyi geçici olarak depoladım.
            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }

        if (!String.IsNullOrEmpty(category) && category != "0")
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }


        // Kategori listeleme. Viewmodel den çekildiği için artık ihtiyaç yok.
        // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);
        var model = new ProductViewModel
        {
            //Modelin içindeki Products buradaki products eşit.
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        //Create.cshtml içerisine gönderdik ordan verileri çektik.
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product model)
    {
        Repository.CreateProduct(model); //Repository üzerinden CreateProduct ı çağır ve ona modele gelen bilgileri yazdır.
        return RedirectToAction("Index");
    }

}

//ViewBag.SearchString = searchString; = arama yapıldığında aranan kelimenin search inputunda kalmasını sağlar. Layout kısmında value="@ViewBag.SearchString" çağır.
