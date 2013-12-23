namespace Sentinel.Web.Services
{
	using System;
	using System.Diagnostics.Contracts;

	using Sentinel.Web.Models.Gallery;


	/// <summary>
	/// Metadata class that contains the Code Contracts for the <see cref="IImageService"/> interface.
	/// </summary>
	[ContractClassFor( typeof( IImageService ) )]
	public abstract class ImageServiceContract : IImageService
	{
		public ViewGalleriesVM GetGalleries()
		{
			return default( ViewGalleriesVM );
		}

		public ViewGalleryVM GetGallery( string folderName )
		{
			Contract.Requires( !String.IsNullOrEmpty( folderName ) );
			return default( ViewGalleryVM );
		}
	}
}