namespace Sentinel.Web
{
	using System.Web.Optimization;


	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles( BundleCollection bundles )
		{
			bundles.Add( new ScriptBundle( "~/bundles/jquery" ).Include(
									"~/Static/lib/jquery-{version}.js" ) );

			bundles.Add( new ScriptBundle( "~/bundles/jqueryval" ).Include(
									"~/Static/lib/jquery.validate*" ) );

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add( new ScriptBundle( "~/bundles/modernizr" ).Include(
									"~/Static/lib/modernizr-*" ) );

			bundles.Add( new ScriptBundle( "~/bundles/bootstrap" ).Include(
								"~/Static/bootstrap/js/bootstrap.js",
								"~/Static/bootstrap/js/respond.js" ) );

			bundles.Add( new StyleBundle( "~/bundles/static/bootstrap/css/" ).Include(
								"~/Static/bootstrap/css/metro-bootstrap.min.css",
								"~/Static/css/my.css" ) );
		}
	}
}
