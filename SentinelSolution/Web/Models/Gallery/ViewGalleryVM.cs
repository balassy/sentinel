namespace Sentinel.Web.Models.Gallery
{
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;


	/// <summary>
	/// The view-model for the page that shows the details of a single gallery.
	/// </summary>
	public sealed class ViewGalleryVM
	{
		public string Title { get; set; }

		[SuppressMessage( "Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Required by ASP.NET MVC model binding." )]
		[SuppressMessage( "Microsoft.Design", "CA1002:DoNotExposeGenericLists", Justification = "This view-model class is sealed to prevent inheritance." )]
		public List<string> PhotoUrls { get; set; }		
	}
}