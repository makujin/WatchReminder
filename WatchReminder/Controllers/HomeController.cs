using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatchReminder.Controllers
{
    public class HomeController : Controller
    {
        Models.WatchReminderEntities bd = new Models.WatchReminderEntities();

        public ActionResult Index()
        {
            var listFilms = bd.Films;
            return View(listFilms);
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