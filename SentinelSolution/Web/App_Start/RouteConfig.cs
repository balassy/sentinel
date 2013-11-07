using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sentinel.Web
{
	public class RouteConfig
	{
		public static void RegisterRoutes( RouteCollection routes )
		{
			routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

			routes.MapRoute( "Login", "Bejelentkezes", new { controller = "Home", action = "Login" } );
			routes.MapRoute( "ViewGalleries", "Keptar", new { controller = "Gallery", action = "ViewGalleries" } );
			routes.MapRoute( "ViewGallery", "Keptar/{folderName}", new { controller = "Gallery", action = "ViewGallery" } );

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
