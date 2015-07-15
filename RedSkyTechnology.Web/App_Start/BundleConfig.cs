using System.Web.Optimization;

namespace RedSkyTechnology.Web
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

            bundles.Add(new ScriptBundle("~/bundles/smoothscroll").Include(
                "~/Scripts/smoothscroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery.isotope").Include(
                "~/Scripts/jquery.isotope.js"));

            bundles.Add(new ScriptBundle("~/bundles/owl").Include(
                "~/Scripts/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/site/css").Include(
                "~/Content/site.css",
                "~/Content/responsive.css"
                ));

            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/owl/css").Include(
                      "~/Content/OwlCarousel/owl.carousel.css",
                      "~/Content/OwlCarousel/owl.theme.css"));
        }
    }
}
