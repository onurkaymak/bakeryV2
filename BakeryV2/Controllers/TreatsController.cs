using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BakeryV2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BakeryV2.Controllers
{
  [Authorize]
  public class TreatsController : Controller
  {
    private readonly BakeryV2Context _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, BakeryV2Context db)
    {
      _userManager = userManager;
      _db = db;
    }



  }
}