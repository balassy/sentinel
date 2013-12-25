namespace Sentinel.Web.Models.Gallery
{
	using System.Diagnostics.CodeAnalysis;

	public sealed class ViewGallerySummaryVM
	{
		public string FolderName { get; set; }

		public int Count { get; set; }

		[SuppressMessage( "Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = "Always used as a whole string, never parsed." )]
		public string ThumbnailUrl { get; set; }
	}
}