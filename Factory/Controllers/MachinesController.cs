using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class ClassTwoController : Controller
  {
    private readonly FactoryContext _db;

    public CuisineController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ClassTwo> model = _db.ClassTwo.ToList();
      return View(model);
    }
  }
}