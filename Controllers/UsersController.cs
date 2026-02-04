using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

namespace MakersBnB.Controllers;

public class UsersController : Controller
{
    private readonly MakersBnBDbContext _context;

    public UsersController(MakersBnBDbContext context)
    {
        _context = context;
    }

    // GET /Users/New
    public IActionResult New()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        ViewBag.Message = "Account created"; 
        return View("New");
        // return Redirect("/Spaces");
    }

}
