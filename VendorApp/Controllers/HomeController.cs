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
    [HttpGet]
    [Route("vendors/create")]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("vendors/create")]
    public ActionResult Create(Vendor vendor)
    {
        if (ModelState.IsValid)
        {
            new Vendor(vendor.Name);
            return RedirectToAction("Index");
        }
        return View(vendor);
    }
    [HttpPost]
    [Route("vendors/{id}")]
    public ActionResult Show(int id)
    {
        Vendor selectedVendor = Vendor.Find(id);
        if (selectedVendor == null)
        {
            return NotFound();
        }
        
        return View("Orders", selectedVendor);
    }
}
