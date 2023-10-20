using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BakeryV2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;

namespace BakeryV2.Controllers
{
  // [Authorize]
  public class FlavorsController : Controller
  {
    private readonly BakeryV2Context _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, BakeryV2Context db)
    {
      _userManager = userManager;
      _db = db;
    }

    // [AllowAnonymous]
    public ActionResult Index()
    {
      List<Flavor> allFlavors = _db.Flavors.ToList();
      return View(allFlavors);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      if (!ModelState.IsValid)
      {
        return View(flavor);
      }
      else
      {
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

  }
}