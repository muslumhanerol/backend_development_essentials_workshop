using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project_second_formsApp.Models;

namespace project_second_formsApp.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    public IActionResult Index(string searchString)
    {
        var products = Repository.Products;
        if (!String.IsNullOrEmpty(searchString))
        {
            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();

        }
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
