using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearnDotnet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*           routes.MapRoute(
                           "MoviesByReleaseDate",
                           "movies/released/{year}/{month}" ,
                           new { Controller="Movies" , action = "ByReleaseDate"},
                           new { year =@"2020|2021" , month =@"\d{2}"}); // ajout des contraintes sur la date
                       */
          routes.MapMvcAttributeRoutes();// permet de creer une route personnalisee


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
