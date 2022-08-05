using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.controller
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    
    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Engineers = _db.Engineers;
      ViewBag.Machines = _db.Machines;
      return View();
    }
  }
}