namespace Sentinel.Web.Controllers
{
	using System;
	using System.Diagnostics.Contracts;
	using System.Web.Mvc;
	using Sentinel.Web.Models.Gallery;
	using Sentinel.Web.Services;

	using Ninject;


	[Authorize]
	public partial class GalleryController : Controller
	{
		[Inject]
		public IImageService ImageService { get; set; }


		public virtual ActionResult ViewGalleries()
		{
			ViewGalleriesVM model = this.ImageService.GetGalleries();
			return View( model );
		}


		public virtual ActionResult ViewGallery( string folderName )
		{
			Contract.Requires( !String.IsNullOrEmpty( folderName ) );

			ViewGalleryVM model = this.ImageService.GetGallery( folderName );
			return View( model );
		}

	}
}