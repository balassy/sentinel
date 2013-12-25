namespace Sentinel.Web
{
	using System.Web.Mvc;
	using System.Web.Routing;


	/// <summary>
	/// Encapsulates the details of setting up the routing.
	/// </summary>
	public static class RouteConfig
	{
		/// <summary>
		/// Registers all routes for the site.
		/// </summary>
		/// <param name="routes">The collection of routes to extend.</param>
		public static void RegisterRoutes( RouteCollection routes )
		{
			routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

			routes.MapRoute( RouteNames.LogOn, "LogOn", MVC.Home.LogOn() );
			routes.MapRoute( RouteNames.LogOff, "LogOff", MVC.Home.LogOff() );
			routes.MapRoute( RouteNames.ViewGalleries, "Galleries", MVC.Gallery.ViewGalleries() );
			routes.MapRoute( RouteNames.ViewGallery, "Galleries/{folderName}", MVC.Gallery.ViewGallery() );

			// The default route that is used when no custom route is specified for an action.
			routes.MapRoute( RouteNames.Default, "{controller}/{action}", MVC.Home.Index() );
		}
	}
}
