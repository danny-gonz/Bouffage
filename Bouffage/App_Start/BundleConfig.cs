using System.Web;
using System.Web.Optimization;

namespace Bouffage
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

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
               "~/Scripts/custom.js"
               ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                     
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/bouffage-theme").Include(
                "~/Content/bouffage-theme/animate.css",
                "~/Content/bouffage-theme/documenter_style.css",
                "~/Content/bouffage-theme/style-rtl.css",
                "~/Content/bouffage-theme/style.css",
                "~/Content/bouffage-theme/styles/shCore.css",
                "~/Content/bouffage-theme/styles/shCoreDefault.css",
                "~/Content/bouffage-theme/styles/shCoreDjango.css",
                "~/Content/bouffage-theme/styles/shCoreEclipse.css",
                "~/Content/bouffage-theme/styles/shCoreEmacs.css",
                "~/Content/bouffage-theme/styles/shCoreFadeToGrey.css",
                "~/Content/bouffage-theme/styles/shCoreMDUltra.css",
                "~/Content/bouffage-theme/styles/shCoreMidnight.css",
                "~/Content/bouffage-theme/styles/shCoreRDark.css",
                "~/Content/bouffage-theme/styles/shThemeDefault.css",
                "~/Content/bouffage-theme/styles/shThemeDjango.css",
                "~/Content/bouffage-theme/styles/shThemeEclipse.css",
                "~/Content/bouffage-theme/styles/shThemeEmacs.css",
                "~/Content/bouffage-theme/styles/shThemeFadeToGrey.css",
                "~/Content/bouffage-theme/styles/shThemeMDUltra.css",
                "~/Content/bouffage-theme/styles/shThemeMidnight.css",
                "~/Content/bouffage-theme/styles/shThemeRDark.css"
              




                ));


        }
    }
}
