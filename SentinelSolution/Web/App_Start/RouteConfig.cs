namespace Sentinel.Web
{
	using System.Web.Mvc;
	using System.Web.Routing;


	public class RouteConfig
	{
		public static void RegisterRoutes( RouteCollection routes )
		{
			routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

			routes.MapRoute( RouteNames.Login, "Login", MVC.Home.Login() );
			routes.MapRoute( RouteNames.Logoff, "Logoff", MVC.Home.Logoff() );
			routes.MapRoute( RouteNames.ViewGalleries, "Galleries", MVC.Gallery.ViewGalleries() );
			routes.MapRoute( RouteNames.ViewGallery, "Galleries/{folderName}", MVC.Gallery.ViewGallery() );

			routes.MapRoute( RouteNames.Default, "{controller}/{action}", MVC.Home.Index() );
		}
	}
}
