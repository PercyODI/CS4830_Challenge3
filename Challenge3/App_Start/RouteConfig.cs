using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Challenge3
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Off;
            // FriendlyUrls has been disabled to allow POST data
            //routes.EnableFriendlyUrls(settings);

            // Set Page1 to be a default route
            routes.MapPageRoute("", "Default", "~/Page1.aspx");
            routes.MapPageRoute("", "", "~/Page1.aspx");
        }
    }
}
