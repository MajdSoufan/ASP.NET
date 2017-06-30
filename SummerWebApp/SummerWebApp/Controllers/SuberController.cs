using SummerWebApp.Models;
using SummerWebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SummerWebApp.Controllers
{
    public class SuberController : Controller
    {
        // GET: Suber
        public ActionResult Index(int id)
        {
            var suber = new Suber() { Id = 5, Name = "Sam" };
            var customers = new List<Customer>
            {
                new Customer{ Name = "One"},
                new Customer{ Name = "Two"}
            };

            var viewModel = new RandomSuberViewModel
            {
                Suber = suber,
                Customers = customers
            };

            return View(ViewModel);

            //return Content("sameer "+id);
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortBy ="name"});
        }

        public ActionResult Edit(int suberId)
        {
            return Content("id= " + suberId);
        }

        public ActionResult Random(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content(String.Format("pageIndex={0}&sortB={1}",pageIndex,sortBy)); 
        }

        public ActionResult NewFunction()
        {
            var suber = new Suber() { Id = 1, Name = "Sameer" };

            var viewResult = new ViewResult();
           // viewResult.ViewData.Model

            return View(suber);
        }

        [Route("suber/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year= " + year + " Month " + month);
        }

    }
}