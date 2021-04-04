using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnDotnet.Models;
using LearnDotnet.ViewModels;

namespace LearnDotnet.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //chaque controller a ce qu'on appelle un viewDate qui est un view
            //data dictionnarie
            //return Content("helloword Herman");
            //return HttpNotFound();
            //return new EmptyResult();
            //  return RedirectToAction("Index", "Home", new { page = 1 , sortBy = "name"}) ;
            var movie = new Movie() { Name = "Herman " };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customers 1 " },
                new Customer{Name = "Customees 2 "}
            };
            var viewModel = new RandomMovieViewModel() {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult edit(int id)
        {
            return Content(" id is " + id);
        }

        public ActionResult Index(int? pageIndex , string sortedBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortedBy))
                sortedBy = "name";

            return Content(String.Format("pageIndex = {0} & sortedBy ={1}", pageIndex, sortedBy));
        }
       
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year , int month)
        {
            return Content(year + " / " + month);
        }
    }
}