using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieList(string name, int numTimes)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public ActionResult Movies(string name, int number = 1)
        {
            var viewModel = new MoviesViewModel
            {
                Message = "Hello " + name,
                Number = number
            };
            return View(viewModel);
        }

        public class MoviesViewModel
        {
            public string Message { get; set; }
            public int Number { get; set; }
        }
    }
}