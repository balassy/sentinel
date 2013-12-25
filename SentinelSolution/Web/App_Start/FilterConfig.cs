namespace Sentinel.Web
{
	using System.Diagnostics.Contracts;
	using System.Web.Mvc;


	/// <summary>
	/// Encapsulates the details of setting up ASP.NET MVC filters.
	/// </summary>
	public class FilterConfig
	{
		/// <summary>
		/// Registers the global filters that are available for all controllers and actions..
		/// </summary>
		/// <param name="filters">The collection of filters to extend.</param>
		public static void RegisterGlobalFilters( GlobalFilterCollection filters )
		{
			Contract.Requires( filters != null );

			filters.Add( new HandleErrorAttribute() );
		}
	}
}
