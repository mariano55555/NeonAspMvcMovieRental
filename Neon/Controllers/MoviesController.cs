using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Neon.Models;

namespace Neon.Controllers
{
    public class MoviesController : Controller
    {

    private NeonContext _context;

    public MoviesController()
    {
       _context = new NeonContext();
    }

     protected override void Dispose(bool disposing)
    {
         _context.Dispose();
    }



    // GET: Movies
    public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek" };

            return View(movie);
        }

        public ViewResult Index()
        {
            //var movies = GetMovies();
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Show(int id)
        {
            //var customer = GetMovies().FirstOrDefault(c => c.Id == id);
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}