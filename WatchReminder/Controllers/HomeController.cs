using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatchReminder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random rd = new Random();
            List<string[]> MyList = new List<string[]>();        
            for(int i=0; i<20; i++)
            {
                MyList.Add(new []{"Аниме номер " + i.ToString(), (i!=rd.Next(0,20))? "Это крутая анимешечка.":"Люблю Вофку"});
            }
            return View(MyList);
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