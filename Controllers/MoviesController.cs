using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly.Models;
using Vividly.ViewModels.

namespace Vividly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name= "Customer 1"},
                new Customer { Name= "Customer 1"},
            };

            var viewModel = new RandomMoviewViewModel();

            return View(movie);
        }
    }
}