using Record_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Record_Store.Controllers
{
    public class HomeController : Controller
    {
        ChinookEntities db = new ChinookEntities();
        public ActionResult Index()
        {
            return View();
            //db.InvoiceLine.Where(x => x.TrackId.(X) || X == null)
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}