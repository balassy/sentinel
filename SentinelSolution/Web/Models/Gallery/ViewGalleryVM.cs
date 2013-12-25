namespace Sentinel.Web.Models.Gallery
{
	using System.Collections.Generic;


	/// <summary>
	/// The view-model for the page that shows the details of a single gallery.
	/// </summary>
	public class ViewGalleryVM
	{
		public string Title { get; set; }

		public List<string> PhotoUrls { get; set; }		
	}
}