namespace Sentinel.Web
{
	/// <summary>
	/// Contains the constant route names to avoid the risk of typos when routes are set up and referenced.
	/// </summary>
	public static class RouteNames
	{
		/// <summary>
		/// The name of the default route ("{controller}/{action}").
		/// </summary>
		public const string Default = "Default";

		/// <summary>
		/// The name of the route that logs in the user.
		/// </summary>
		public const string LogOn = "LogOn";

		/// <summary>
		/// The name of the route that logs off the user.
		/// </summary>
		public const string LogOff = "LogOff";

		/// <summary>
		/// The name of the route that lists the galleries.
		/// </summary>
		public const string ViewGalleries = "ViewGalleries";

		/// <summary>
		/// The name of the route that displays a single gallery.
		/// </summary>
		public const string ViewGallery = "ViewGallery";
	}
}