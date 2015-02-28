using System.Web;
using System.Web.Optimization;

namespace lfspinnerBeta
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // css do widokow i skryptow, bibliotek

            bundles.Add(new StyleBundle("~/Content/css").Include(

                //  BOOTSTRAP AND ANIMATION
                        "~/Content/bootstrap.min.css",
                        "~/Content/animate.min.css",
                //  FONT ICONS 
                        "~/assets/icons/icons.css",
                //  CUSTOM STYLESHEETS
                        "~/Content/styles.css",
                //  RESPONSIVE FIXES
                        "~/Content/responsive.css",
                //  COLORS
                        "~/Content/colors/green.css"



                        ));
        }
    }
}
