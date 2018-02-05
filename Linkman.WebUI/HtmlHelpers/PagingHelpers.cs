using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Linkman.WebUI.Models;
using System.Web.Mvc;
using System.Text;

namespace Linkman.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            TagBuilder baseTag = new TagBuilder("ul");

            baseTag.AddCssClass("pagination");
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder aTag = new TagBuilder("a");
                TagBuilder liTag = new TagBuilder("li");

                liTag.AddCssClass("page-item");
                aTag.MergeAttribute("href", pageUrl(i));
                aTag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    liTag.AddCssClass("active");
                }
                aTag.AddCssClass("page-link");
                result.Append(liTag.ToString().Replace("\">", "\">" + aTag.ToString()));
            }
            //baseTag.ToString().Replace(">", ">" + result.ToString());
            return MvcHtmlString.Create(baseTag.ToString().Replace("\">", "\">" + result.ToString()));
        }
    }
}