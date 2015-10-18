﻿using System.Web;
using System.Web.Optimization;

namespace LibrarySystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Kendo/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/Kendo/kendo.all.min.js", // or kendo.all.min.js if you want to use Kendo UI Web and Kendo UI DataViz
                        "~/Scripts/Kendo/kendo.aspnetmvc.min.js"));


            // The Kendo CSS bundle
            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                        "~/Content/Kendo/kendo.common.min.css",
                        "~/Content/Kendo/kendo.default.min.css",
                        "~/Content/Kendo/kendo.common.min.css",
                        "~/Content/Kendo/kendo.default.min.css",
                        "~/Content/Kendo/kendo.dataviz.min.css",
                        "~/Content/Kendo/kendo.dataviz.default.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-responsive.css"));

            // Clear all items from the ignore list to allow minified CSS and JavaScript files in debug mode
            bundles.IgnoreList.Clear();


            // Add back the default ignore list rules sans the ones which affect minified files and debug mode
            bundles.IgnoreList.Ignore("*.intellisense.js");
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);

        }
    }
}
