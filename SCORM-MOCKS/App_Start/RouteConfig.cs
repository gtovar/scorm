using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SCORM_MOCKS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Mock", action = "Index", id = UrlParameter.Optional}
            );
            routes.MapRoute(
                "General",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Mock", action = "General", id = "" }  // Parameter defaults
            );
            routes.MapRoute(
                "Individual",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Mock", action = "Individual", id = "" }  // Parameter defaults
            );
            routes.MapRoute(
                "Examen",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Mock", action = "Examen", id = "" }  // Parameter defaults
            );
            routes.MapRoute(
                "IndividualExamen",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Mock", action = "Individual_Examen", id = "" }  // Parameter defaults
            );
        }
    }
}
