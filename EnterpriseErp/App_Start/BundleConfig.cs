using System.Web;
using System.Web.Optimization;

namespace EnterpriseErp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            //Bundle easyui scripts
            bundles.Add(new ScriptBundle("~/bundles/easyui").Include(
                        "~/Scripts/EasyUi/jquery.easyui.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"
                        ));

            //Bundle theme
            bundles.Add(new StyleBundle("~/Content/themes/EasyUi/css").Include(
                        "~/Content/Site.css",
                        "~/Content/themes/EasyUi/easyui.css",
                        "~/Content/themes/EasyUi/icon.css"
                        ));

            //Force to optimize in debug mode
            BundleTable.EnableOptimizations = true;
        }
    }
}