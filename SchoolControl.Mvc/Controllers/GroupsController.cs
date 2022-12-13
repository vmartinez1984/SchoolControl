using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolControl.Mvc.Models;

namespace SchoolControl.Mvc.Controllers;

public class GroupsController : Controller
{
    private readonly ILogger<GroupsController> _logger;

    public GroupsController(ILogger<GroupsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
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