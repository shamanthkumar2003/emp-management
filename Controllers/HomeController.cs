using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using setups.Models;
using System.Collections.Generic;
using emp-management.Services; 
namespace Setup.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserService _userService; // Inject UserService

    public HomeController(ILogger<HomeController> logger, UserService userService)
    {
        _logger = logger;
        _userService = userService; // Initialize UserService
    }

    public IActionResult Index()
    {
        List<User> users = _userService.GetUsers(); // Fetch data from MySQL
        return View(users); // Pass data to the View
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
