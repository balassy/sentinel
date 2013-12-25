namespace Sentinel.Web
{
	using System.Diagnostics.CodeAnalysis;
	using System.Diagnostics.Contracts;
	using System.Web.Optimization;


	/// <summary>
	/// Encapsulates the details of setting up the bundling and minification of the JavaScript and CSS files.
	/// </summary>
	/// <remarks>
	/// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
	/// </remarks>
	public static class BundleConfig
	{
		// 
		/// <summary>
		/// Registers the CSS and JavaScript bundles.
		/// </summary>
		/// <param name="bundles">The collection of the bundles to extend.</param>
		/// <remarks>
		/// NOTE: The ~/bundles URI segment is used in all bundle URIs to represent the ~/Static folder which contains the CSS and JavaScript files.
		/// </remarks>
		[SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "False alarm, because Code Analysis does not recognize Code Contracts." )]
		public static void RegisterBundles( BundleCollection bundles )
		{
			Contract.Requires( bundles != null );

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

			bundles.Add( new StyleBundle( "~/bundles/css" ).Include(
								"~/Static/css/my.css" ) );
		}
	}
}
