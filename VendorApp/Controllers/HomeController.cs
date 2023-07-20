using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VendorApp.Models;

namespace VendorApp.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

}
