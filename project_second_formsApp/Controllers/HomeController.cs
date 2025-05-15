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
            products = products.Where(p => p.CatagoryId == int.Parse(category)).ToList();
        }


        //Kategori listeleme.
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

}

//ViewBag.SearchString = searchString; = arama yapıldığında aranan kelimenin search inputunda kalmasını sağlar. Layout kısmında value="@ViewBag.SearchString" çağır.
