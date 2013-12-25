namespace Sentinel.Web.Models.Gallery
{
	using System.Collections.Generic;


	/// <summary>
	/// The view-model for the page that lists all galleries.
	/// </summary>
	public class ViewGalleriesVM
	{
		public List<ViewGallerySummaryVM> Galleries { get; set; }		
	}
}