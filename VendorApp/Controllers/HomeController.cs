using Microsoft.AspNetCore.Mvc;
using VendorApp.Models;

namespace VendorApp.Controllers;
public class HomeController : Controller
{
    [HttpGet]
    [Route("/")]
    public ActionResult Index()
    {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
    }
    [HttpGet]
    [Route("/vendors/create")]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("/vendors/create")]
    public ActionResult Create(Vendor vendor)
    {
        if (ModelState.IsValid)
        {
            new Vendor(vendor.Name);
            return RedirectToAction("Index");
        }
        return View(vendor);
    }
    [HttpGet]
    [Route("/vendors/{id}")]
    public ActionResult Show(int id)
    {
        Vendor selectedVendor = Vendor.Find(id);
        if (selectedVendor == null)
        {
            return NotFound();
        }
        
        return View("Orders", selectedVendor);
    }

    [HttpGet]
    [Route("/vendors/{id}/createOrder")]
    public ActionResult CreateOrder(int id)
    {
        Vendor selectedVendor = Vendor.Find(id);
        if (selectedVendor == null)
        {
            return NotFound();
        }

        return View(selectedVendor);
    }

    [HttpPost]
    [Route("/vendors/{id}/createOrder")]
    public ActionResult CreateOrder(int id, Order order)
    {
        Vendor selectedVendor = Vendor.Find(id);
        if (selectedVendor == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            selectedVendor.AddOrder(order);
        }

        return RedirectToAction("Show", new { id = selectedVendor.Id });
    }
}