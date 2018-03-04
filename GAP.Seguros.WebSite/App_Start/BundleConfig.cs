using System.Web;
using System.Web.Optimization;

namespace GAP.Seguros.WebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Login/css").Include(

                      "~/Content/Login.css"));

            bundles.Add(new ScriptBundle("~/Angular").Include(
                     "~/Scripts/angular.min.js"));

            bundles.Add(new ScriptBundle("~/AppPoliza").Include(
                  "~/app/app.module.js"));

            bundles.Add(new ScriptBundle("~/Poliza").Include(
                "~/app/polizas/polizas.config.js",
                "~/app/services/baseSvc.js",
                "~/app/polizas/polizas.facade.js",
                "~/app/polizas/polizas.controller.js"
                ));

            bundles.Add(new ScriptBundle("~/Login/js").Include(
              "~/app/login/login.config.js",
              "~/app/services/baseSvc.js",
              "~/app/login/login.facade.js",
              "~/app/login/login.controller.js"
              ));
        }
    }
}
