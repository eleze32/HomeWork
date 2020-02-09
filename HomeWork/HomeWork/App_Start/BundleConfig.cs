using System.Web;
using System.Web.Optimization;

namespace HomeWork
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquerry/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/js/jquerry/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/SweetAlert2Js").Include(
                        "~/Content/js/SweetAlert2/sweetalert2.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/TinyMceJs").Include(
                        "~/Content/js/tinymce/tinymce.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapJs").Include(
                      "~/Content/js/bootstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/DataTableJs").Include(
                      "~/Content/js/DataTable/datatables.js"));

            bundles.Add(new ScriptBundle("~/bundles/AppJs").Include(
                      "~/Content/js/app.js"));

            bundles.Add(new StyleBundle("~/Content/BootstrapCss").Include(
                      "~/Content/css/bootstrap/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/AppCss").Include(
                      "~/Content/css/app.css"));

            bundles.Add(new StyleBundle("~/Content/DataTablaCss").Include(
                      "~/Content/css/DataTable/datatables.css"));

            bundles.Add(new StyleBundle("~/Content/SweetAlert2Css").Include(
                      "~/Content/css/SweetAlert2/sweetalert2.css"));
        }
    }
}
