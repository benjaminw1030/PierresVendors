using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View();
    }

  }
}