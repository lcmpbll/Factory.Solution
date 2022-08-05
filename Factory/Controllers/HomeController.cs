using Microsoft.AspNetCore.Mvc;

namespace Factory.controller
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}