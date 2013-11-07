namespace Sentinel.Web.Controllers
{
	using System.Collections.Generic;
	using System.IO;
	using System.Web.Mvc;
	using Sentinel.Web.Models.Gallery;


	[Authorize]
	public partial class GalleryController : Controller
	{
		private const string StorageFolderVirtualPath = "~/Photos";


		public virtual ActionResult ViewGalleries()
		{
			ViewGalleriesVM model = new ViewGalleriesVM
			{
				Series = new List<SeriesVM>()
			};

			string storageFolderPhysicalPath = this.Server.MapPath( StorageFolderVirtualPath );
			string[] folderPhysicalPaths = Directory.GetDirectories( storageFolderPhysicalPath );
			foreach( string folderPhysicalPath in folderPhysicalPaths )
			{
				string[] filePhysicalPaths = Directory.GetFiles( folderPhysicalPath, "*.jpg" );

				if( filePhysicalPaths.Length > 0 )
				{
					string folderName = Path.GetFileName( folderPhysicalPath );
					string thumbnailFileName = Path.GetFileName( filePhysicalPaths[ 0 ] );
					string thumbnailVirtualPath = Path.Combine( Path.Combine( StorageFolderVirtualPath, folderName ), thumbnailFileName );

					SeriesVM series = new SeriesVM
					{
						FolderName = folderName,
						Count = filePhysicalPaths.Length,
						ThumbnailUrl = thumbnailVirtualPath
					};
					model.Series.Add( series );					
				}
			}

			return View( model );
		}


		public virtual ActionResult ViewGallery( string folderName )
		{
			return View();
		}

	}
}