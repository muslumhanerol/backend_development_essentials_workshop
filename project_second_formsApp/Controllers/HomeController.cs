using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project_second_formsApp.Models;

namespace project_second_formsApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController()
    {

    }

    public IActionResult Index()
    {
        return View(Repository.Products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
