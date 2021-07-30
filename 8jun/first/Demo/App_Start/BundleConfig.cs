using System.Web;
using System.Web.Optimization;

namespace Demo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/ajax").Include(
                      "~/Scripts/jquery.unobtrusive-ajax.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/layout/css").Include(
                      "~/assets/css/bootstrap.css"
                      ));

            bundles.Add(new StyleBundle("~/vendors/css").Include(
                     "~/assets/vendors/simple-datatables/style.css",
                     "~/assets/vendors/perfect-scrollbar/perfect-scrollbar.css",
                     "~/assets/vendors/bootstrap-icons/bootstrap-icons.css"
                     ));

            bundles.Add(new StyleBundle("~/app/css").Include(
                     "~/assets/css/app.css"
                     
                     ));

            bundles.Add(new StyleBundle("~/auth/css").Include(
                    "~/assets/css/pages/auth.css"
                    ));



            bundles.Add(new ScriptBundle("~/vender/js").Include(
                       "~/assets/vendors/perfect-scrollbar/perfect-scrollbar.min.js"
                        
                       ));


            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                       "~/assets/js/bootstrap.bundle.min.js"

                       ));

            bundles.Add(new ScriptBundle("~/datatables/js").Include(
                     "~/assets/vendors/simple-datatables/simple-datatables.js"

                     ));

            bundles.Add(new ScriptBundle("~/app/js").Include(
                      "~/assets/js/main.js"

                      ));


        }
    }
}
