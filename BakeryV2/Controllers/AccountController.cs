using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BakeryV2.Models;
using BakeryV2.ViewModels;

namespace BakeryV2.Controllers
{
  public class AccountController : Controller
  {
    private readonly BakeryV2Context _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(
      UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, BakeryV2Context db
      )
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

  }
}