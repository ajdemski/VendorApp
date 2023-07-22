using Microsoft.AspNetCore.Mvc;
using VendorApp.Models;

namespace VendorApp.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
    }
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Vendor vendor)
    {
        if (ModelState.IsValid)
        {
            new Vendor(vendor.Name);
            return RedirectToAction("Index");
        }
        return View(vendor);
    }

    public ActionResult Details(int id)
    {
        Vendor vendor = Vendor.Find(id);
        return View(vendor);
    }
}
