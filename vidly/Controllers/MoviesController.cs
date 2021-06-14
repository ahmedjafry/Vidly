using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    //Controller class
    public class MoviesController : Controller
    {
        // GET: Movies/
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);

        }

        private object GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}