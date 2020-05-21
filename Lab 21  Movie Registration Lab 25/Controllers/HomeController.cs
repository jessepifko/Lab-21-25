using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_21__Movie_Registration_Lab_25.Models;

namespace Lab_21__Movie_Registration_Lab_25.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration(Movie movie)
        {
            return View(movie);
        }

        public IActionResult Result(int id, string title, string genre, int year, string actors, string directors)
        {
            Movie movie = new Movie(id, title, genre, year, actors, directors);

            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return RedirectToAction("Registration", movie);
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
