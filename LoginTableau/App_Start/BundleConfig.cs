using System.Web;
using System.Web.Optimization;

namespace LoginTableau
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Personalizado").Include(
                "~/Login_v1/vendor/bootstrap/css/bootstrap.min.css",
                "~/Login_v1/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Login_v1/vendor/animate/animate.css",
                "~/Login_v1/vendor/css-hamburgers/hamburgers.min.css",
                "~/Login_v1/vendor/select2/select2.min.css",
                "~/Login_v1/css/util.css",
                "~/Login_v1/css/main.css",
                "~/Content/toastr.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Login_v1/vendor/jquery/jquery-3.2.1.min.js",
                "~/Login_v1/vendor/bootstrap/js/popper.js",
                "~/Login_v1/vendor/bootstrap/js/bootstrap.min.js",
                "~/Login_v1/vendor/select2/select2.min.js",
                "~/Login_v1/vendor/tilt/tilt.jquery.min.js",
                "~/Login_v1/js/main.js",
                "~/Scripts/toastr.js"
                ));

        }
    }
}
