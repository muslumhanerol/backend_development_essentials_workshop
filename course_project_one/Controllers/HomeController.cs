// Üst sayfanın içindeki sayfalar

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using course_project_one.Models;

namespace course_project_one.Controllers;

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
