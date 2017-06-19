using SummerWebApp.Models;
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
            var suber = new Suber() { Id = 5 };
            //return View(suber);
            return Content("sameer "+id);
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

        [Route("suber/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year= " + year + " Month " + month);
        }

    }
}