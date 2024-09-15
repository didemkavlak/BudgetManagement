using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BudgetM.Dashboard
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


			routes.MapRoute(
			name: "BudgetDelete",
			url: "BudgetDelete",
			defaults: new { controller = "Budget", action = "Delete", id = UrlParameter.Optional }
		);

			routes.MapRoute(
              name: "BudgetCreate",
              url: "BudgetCreate",
              defaults: new { controller = "Budget", action = "Create", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "BudgetList",
                url: "BudgetList",
                defaults: new { controller = "Budget", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
            
            
        }
    }
}
