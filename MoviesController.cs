using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models; // to be able to use var movie = new Movie()
using Vidly.ViewModels; // to use var viewModel = new RandomMovieViewModel // creates view Model object
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Vidly.Controllers
{

    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies/Random
        /*public ActionResult Random() //Index was changed to Random
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer> // list of customers
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel // creates view Model object
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel); //for model object movie was changed to viewModel

            //ViewData["Movie"] = movie; // another way to pass data to Views; after this in return view movie can be removed
            //return View();             // Not suggested to use



        }
        //for attribute Routing
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] //Route Attribute(url template), regex - specifies that only 2 digits

        public ActionResult ByReleaseYear(int year, int month) //action method created for 2019/01 (year/month route)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        */
        //Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Name).ToList();
            return View(movies);
        }

        public ViewResult New()
        {
            var genre = _context.Genres.ToList();

            var viewModel = new NewMovieViewModel
            {
                Genre = genre
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new NewMovieViewModel
            {
                Movie = movie,
                Genre = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);

            }

            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}

