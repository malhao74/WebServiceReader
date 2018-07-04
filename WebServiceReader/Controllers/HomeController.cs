using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

[assembly: CLSCompliant(true)]
namespace WebServiceReader
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            QuoteModel quote = DataLayer.Get();

            // Check to see if there is a returned quote
            if (quote == null)
            {
                return Content("The web service is not running ...");
            }

            // Get the quote information to the view
            ViewData["quote"] = quote.Quote;
            ViewData["author"] = quote.Author;
            ViewData["category"] = quote.Cat;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Quotes";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Luia Malhao";

            return View();
        }
    }
}