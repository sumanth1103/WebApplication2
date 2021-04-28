using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Movie movie)
        {
            using(MovieContext db = new MovieContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
            return View();
        }
    }
}
