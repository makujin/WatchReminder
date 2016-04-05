﻿using System.Web;
using System.Web.Optimization;

namespace WatchReminder
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        /*"~/Scripts/jquery-1.10.2.js",*/
                    
                        "~/Scripts/jquery-1.10.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  
                "~/Scripts/bootstrap.min.js",
                      "~/Scripts/jasny-bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    
                     "~/Content/bootstrap.min.css",
                      "~/Content/jasny-bootstrap.min.css",
                      "~/Content/Site.css"));
        }
    }
}
