using System.Web;
using System.Web.Optimization;

namespace PaseosEcologicos
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/reset.css",
                "~/Content/layout.css",
                "~/Content/style.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                "~/Scripts/cufon-yui.js",
                "~/Scripts/cufon-replace.js",
                "~/Scripts/Adamina_400.font.js",
                "~/Scripts/jquery.jqtransform.js",
                "~/Scripts/script.js",
                "~/Scripts/kwicks-1.5.1.pack.js",
                "~/Scripts/atooltip.jquery.js",
                "~/Scripts/jquery.steps.min.js"
            ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/bootstrap.min.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/angular-resource.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/application/app.js",
                "~/Scripts/application/router.js",
                "~/Scripts/application/*Provider.js",
                "~/Scripts/application/*Controller.js"
                ));

            bundles.Add(new StyleBundle("~/Content/wizard").Include(
                "~/Content/bootstrap-wizard.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/wizard").Include(
                "~/Scripts/bootstrap-wizard.min.js"
                ));

            bundles.IgnoreList.Clear();
        }
    }
}