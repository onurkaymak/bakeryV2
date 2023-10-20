using Microsoft.AspNetCore.Mvc;
using BakeryV2.Models;
using System.Collections.Generic;
using System.Linq;

namespace BakeryV2.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryV2Context _db;
    public HomeController(BakeryV2Context db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();

      Treat[] treats = _db.Treats.ToArray();
      model.Add("treats", treats);

      Flavor[] flavors = _db.Flavors.ToArray();
      model.Add("flavors", flavors);

      return View(model);
    }
  }
}

