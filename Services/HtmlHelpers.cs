﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portfolio.Services
{
    public static class HtmlHelpers
    {
        public static string ActiveClass(this IHtmlHelper htmlHelper, string route)
        {
            var routeData = htmlHelper.ViewContext.RouteData;

            var pageRoute = routeData.Values["page"]!.ToString();

            return route == pageRoute ? "page-active" : "";
        }
    }
}
