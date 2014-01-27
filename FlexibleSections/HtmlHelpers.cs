using System.Text;
using System.Web.Mvc;

namespace FlexibleSections
{
    public static class HtmlHelpers
    {
        public static Section AddToSection(this WebViewPage webPage, string section)
        {
            return new Section(webPage, section);
        }

        public static MvcHtmlString Section(this WebViewPage webPage, string section)
        {
            var builder = webPage.Builder(section);

            return new MvcHtmlString(builder.ToString());
        }

        public static string Key(string section)
        {
            return string.Format("__FLEXIBLE_SECTION_{0}", section);
        }

        public static StringBuilder Builder(this WebViewPage webPage, string section)
        {
            return webPage.Context.Items[HtmlHelpers.Key(section)] as StringBuilder ?? new StringBuilder();
        }
    }
}