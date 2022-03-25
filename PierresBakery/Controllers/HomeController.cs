using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PierresBakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresBakeryContext _db;

    public HomeController(PierresBakeryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var model = _db;
      return View(model);
    }
  }
}