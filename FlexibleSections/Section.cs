using System;
using System.IO;
using System.Web.Mvc;

namespace FlexibleSections
{
    public class Section : IDisposable
    {
        protected WebViewPage _webPage;
        protected string _section;

        public Section(WebViewPage webPage, string section)
        {
            _webPage = webPage;
            _section = section;

            _webPage.OutputStack.Push(new StringWriter());
        }

        public void Dispose()
        {
            var content = _webPage.OutputStack.Pop().ToString();

            var builder = _webPage.Builder(_section);

            builder.Append(content);
            _webPage.Context.Items[HtmlHelpers.Key(_section)] = builder;
        }
    }
}