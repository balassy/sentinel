using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sentinel.Web
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters( GlobalFilters.Filters );
			RouteConfig.RegisterRoutes( RouteTable.Routes );
			BundleConfig.RegisterBundles( BundleTable.Bundles );

			// Security: Remove the X-AspNetMVc-Version: 5.0 HTTP header.
			MvcHandler.DisableMvcResponseHeader = true;
		}


		protected void Application_PreSendRequestHeaders()
		{
			// Security: Remove the Server: Microsoft-IIS/8.0 HTTP header.
			this.Response.Headers.Remove( "Server" );
		}

	}
}
