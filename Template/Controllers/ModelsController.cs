using Microsoft.AspNetCore.Mvc;
using Template.Models;
using System.Collections.Generic;

namespace Template.Controllers
{
  public class ModelsController : Controller
  {

    [HttpGet("/models")]
    public ActionResult Index()
    {
      return View();
    }

  }
}