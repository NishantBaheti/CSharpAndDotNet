using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        // want to see random movie
        // /movies/random 
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Avengers" };
            return View(movie);
        }
    }
}