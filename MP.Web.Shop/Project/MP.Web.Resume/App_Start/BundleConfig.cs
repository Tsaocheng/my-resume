using System.Web;
using System.Web.Optimization;

namespace MP.Web.Minipig
{    /// <summary>
     /// css檔 Bundle的Key值
     /// </summary>
    public class StylesBundleKey
    {
        /// <summary>
        /// 導覽列 CSS
        /// </summary>
        public const string MegaNavbarSkin = "~/Content/MegaNavbar/assets/skins";
    }

    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //20170620 曹傑程 導覽列所有Skin入bundle
            bundles.Add(
               new StyleBundle(StylesBundleKey.MegaNavbarSkin).IncludeDirectory("~/Content/MegaNavbar/assets/css/skins", "*.css")
           );
        }
    }
}
