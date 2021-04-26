using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private DBContext _context { get; set; }

        public MoviesController()
        {
            this._context = new DBContext();
        }

        protected override void Dispose(bool disposing)
        {
            this._context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = this._context.Movies.Include(e => e.Genre).ToList();
            return View(movies);
        }

        [Route]
        public ActionResult Details(int id)
        {
            var movie = this._context.Movies.Include(e => e.Genre).FirstOrDefault(e => e.Id == id);

            return View(movie);
        }
    }
}