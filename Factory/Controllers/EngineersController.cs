using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class ClassOneController : Controller
  {
    private readonly FactoryContext _db;

    public ClassOneController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ClassOne> model = _db.ClassOnes.Include(classOne => classOne.ClassTwo).ToList();
      return View(model);
    }
  }
}