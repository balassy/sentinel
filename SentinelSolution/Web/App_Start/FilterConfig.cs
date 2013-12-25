namespace Sentinel.Web
{
	using System.Diagnostics.CodeAnalysis;
	using System.Diagnostics.Contracts;
	using System.Web.Mvc;


	/// <summary>
	/// Encapsulates the details of setting up ASP.NET MVC filters.
	/// </summary>
	public static class FilterConfig
	{
		/// <summary>
		/// Registers the global filters that are available for all controllers and actions..
		/// </summary>
		/// <param name="filters">The collection of filters to extend.</param>
		[SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "False alarm, because Code Analysis does not recognize Code Contracts." )]
		public static void RegisterGlobalFilters( GlobalFilterCollection filters )
		{
			Contract.Requires( filters != null );

			filters.Add( new HandleErrorAttribute() );
		}
	}
}
