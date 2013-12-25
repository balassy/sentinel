namespace Sentinel.Web.Services
{
	using System.Diagnostics.CodeAnalysis;
	using System.Diagnostics.Contracts;
	using Sentinel.Web.Models.Gallery;


	/// <summary>
	/// Contract for service components which encapsulate the details of the image file operations.
	/// </summary>
	[ContractClass( typeof( ImageServiceContract ) )]
	public interface IImageService
	{
		/// <summary>
		/// Gets the list of the available galleries.
		/// </summary>
		/// <returns>The list of galleries.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "The method indicates more complex logic." )]
		ViewGalleriesVM GetGalleries();


		/// <summary>
		/// Gets the details of a gallery.
		/// </summary>
		/// <param name="folderName">The name of the folder which contains the gallery.</param>
		/// <returns>The details of the specified gallery.</returns>
		ViewGalleryVM GetGallery( string folderName );
	}
}
