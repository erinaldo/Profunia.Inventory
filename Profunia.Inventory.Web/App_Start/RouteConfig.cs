using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Profunia.Inventory.Web
{
    public class RouteConfig
    {
        public const string LoginRouteName = "LogIn";

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(LoginRouteName, "Log-In", new { controller = "AccountMvc", Action = "LogIn" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AccountMvc", action = "LogIn", id = UrlParameter.Optional }
            );
        }
    }
}
