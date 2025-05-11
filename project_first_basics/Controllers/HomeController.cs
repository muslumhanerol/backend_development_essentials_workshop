// Birer Sayfa, ana sayfa ana başlık gibi

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project_one.Models;

namespace project_one.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
