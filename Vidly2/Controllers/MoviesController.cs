using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using System.Data.Entity;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool dispose)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            //Get movies.
            //var movies = _context.Movies.Include(m => m.Genre).ToList();
            IEnumerable<Movie> movies = _context.Movies.Include(m => m.Genre).ToList();

            if(movies == null)
            {
                return HttpNotFound();
            }

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(g => g.Genre).FirstOrDefault(m => m.Id == id);

            return View(movie);
        }
    }
}