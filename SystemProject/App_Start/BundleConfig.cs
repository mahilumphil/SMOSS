﻿using System.Web;
using System.Web.Optimization;

namespace SystemProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery.js",
                      "~/Scripts/jquery-1.10.2.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/menu.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/toastr.min.js",
                      "~/wijmo/controls/wijmo.min.js",
                      "~/wijmo/controls/wijmo.grid.min.js",
                      "~/wijmo/controls/wijmo.input.min.js",
                      "~/Scripts/nprogress.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/bootstrap-theme.min.css",
                      "~/Content/stylish-portfolio.css",
                      "~/Content/toastr.min.css",
                      "~/wijmo/styles/wijmo.min.css",
                      "~/Content/nprogress.css"
                      ));


            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                     "~/font-awesome/css/font-awesome.css",
                     "~/font-awesome/css/font-awesome.min.css"  
                    ));
        }
    }
}
