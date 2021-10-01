using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/search_by_vendor")]
    public ActionResult SearchByVendor()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderDate, int orderPrice, string orderPriority)
    {
      bool priority = false;
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      if (orderPriority == "on")
      {
        priority = true;
      }
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice, priority);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }

    [HttpPost("/vendors/search_results")]
    public ActionResult SearchResults(string vendorName)
    {
      List<Vendor> searchResults = new List<Vendor>();
      List<Vendor> allVendors = Vendor.GetAll();
      string searchName = vendorName.ToLower();
      foreach (Vendor vendor in allVendors)
      {
        string name = vendor.Name.ToLower();
        if (name.Contains(searchName))
        {
          searchResults.Add(vendor);
        }
      }
      return View(searchResults);
    }

  }
}