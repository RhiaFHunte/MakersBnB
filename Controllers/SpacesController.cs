using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

namespace MakersBnB.Controllers;

public class SpacesController : Controller
{
    private readonly ILogger<SpacesController> _logger;
    private readonly MakersBnBDbContext _context = null!;
    
    public SpacesController(ILogger<SpacesController> logger, MakersBnBDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {

        var spaces = _context.Spaces.ToList();

        return View(spaces);

    }

    public IActionResult New()
    {
        return View();
    }

    [HttpPost]
    [Route("/Spaces")]
    public IActionResult Create(Space space)
    {
        _context.Spaces.Add(space);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
