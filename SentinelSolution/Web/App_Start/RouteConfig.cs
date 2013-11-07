namespace Sentinel.Web
{
	using System.Web.Mvc;
	using System.Web.Routing;


	public class RouteConfig
	{
		public static void RegisterRoutes( RouteCollection routes )
		{
			routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

			routes.MapRoute( RouteNames.Login, "Bejelentkezes", MVC.Home.Login() );
			routes.MapRoute( RouteNames.ViewGalleries, "Keptar", MVC.Gallery.ViewGalleries() );
			routes.MapRoute( RouteNames.ViewGallery, "Keptar/{folderName}", MVC.Gallery.ViewGallery() );

			routes.MapRoute( RouteNames.Default, "{controller}/{action}/{id}", MVC.Home.Index() );
		}
	}
}
