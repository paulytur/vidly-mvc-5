using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC_5.Models;
using Vidly_MVC_5.ViewModels;

namespace Vidly_MVC_5.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public IEnumerable<Movie> GetMovies() {
            return new List<Movie> {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall E" }
            };
        }


        // GET: Movies/Random
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

        public ActionResult Edit(int id) {
            return Content("id=" + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month) {

            return Content(year + "/" + month);
        }
    }
}