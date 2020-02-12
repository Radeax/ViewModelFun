using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

      return View((object)message);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
      int[] numbers = { 1, 2, 3, 10, 43, 5 };

      return View(numbers);
    }
    [HttpGet("user")]
    public new IActionResult User()
    {
      User user = new User("Joven Poblete");

      return View(user);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
      User[] users = new User[]
      {
        new User("Joven Poblete"),
        new User("Moose Phillips"),
        new User("Jerry"),
        new User("Rene Ricky"),
        new User("Barbarah")
      };

      return View(users);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
