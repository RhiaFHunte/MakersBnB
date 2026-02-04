using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

namespace MakersBnB.Controllers;

public class HomeController : Controller
{
        private readonly ILogger<HomeController> _logger;
        private readonly MakersBnBDbContext _context = null!;
        
        public HomeController(ILogger<HomeController> logger, MakersBnBDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            
            List <Review> reviewsList = _context.Reviews.ToList();

            ViewBag.Reviews = reviewsList;

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
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            ViewBag.Email = "rhiafh@email.com";
            return View();
        }


}
