using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using setups.Models;
using Setup.Services;
using System.Collections.Generic;

namespace Setup.Controllers
{
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
            var model = new DashboardViewModel
            {
                Employees = _userService.GetEmployees(),  // Fetch employees from MySQL
                Tasks = _userService.GetTasks(),         // Fetch tasks from MySQL
                Attendance = _userService.GetAttendance(), // Fetch attendance from MySQL
                Departments = _userService.GetDepartments() // Fetch departments from MySQL
            };

            return View(model); // Pass the correct model to the View
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
