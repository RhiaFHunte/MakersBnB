using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;
using MakersBnB.ActionFilters;

namespace MakersBnB.Controllers;

public class SpacesController : Controller
{
    private readonly MakersBnBDbContext _db;
    private readonly ILogger<SpacesController> _logger;

    public SpacesController(MakersBnBDbContext db, ILogger<SpacesController> logger)
    {
        _db = db;
        _logger = logger;
    }

    // GET /Spaces
    public IActionResult Index()
    {
        var spaces = _db.Spaces.ToList();
        return View(spaces);
    }

    // GET /Spaces/New (protected)
    [ServiceFilter(typeof(AuthenticationFilter))]
    public IActionResult New()
    {
        return View();
    }

    // POST /Spaces (protected)
    [ServiceFilter(typeof(AuthenticationFilter))]
    [HttpPost("/Spaces")]

    public IActionResult Create(string name, string description, int price, int bedrooms, string rules)
    {
        var space = new Space
        {
            Name = name,
            Description = description,
            Price = price,
            Bedrooms = bedrooms,
            Rules = rules
        };

        _db.Spaces.Add(space);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }
}
