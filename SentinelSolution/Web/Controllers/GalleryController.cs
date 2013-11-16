namespace Sentinel.Web.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
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
			IOrderedEnumerable<string> folderPhysicalPaths = Directory.GetDirectories( storageFolderPhysicalPath ).OrderByDescending( p => p );
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
			// Input validation: the folder name must be specified.
			if( String.IsNullOrEmpty( folderName ) )
			{
				throw new ArgumentNullException( "folderName" );
			}

			// Input validation: the folder name must not contain any invalid character.
			if( folderName.IndexOfAny( Path.GetInvalidPathChars() ) > -1 || folderName.IndexOfAny( Path.GetInvalidFileNameChars() ) > -1 )
			{
				throw new ArgumentException( "The folder name contains invalid characters!", "folderName" );
			}

			string folderVirtualPath = Path.Combine( StorageFolderVirtualPath, folderName );
			string folderPhysicalPath = this.Server.MapPath( folderVirtualPath );

			// Integrity check: the folder must exist.
			if( !Directory.Exists( folderPhysicalPath )  )
			{
				throw new ArgumentException( "The specified folder does not exist!", "folderName" );
			}

			// Integrity check: the requested folder must be the direct child of the storage folder.
			string storagePhysicalPath = this.Server.MapPath( StorageFolderVirtualPath );
			string folderParentPhysicalPath = Directory.GetParent( folderPhysicalPath ).FullName;
			if( !folderParentPhysicalPath.Equals( storagePhysicalPath, StringComparison.OrdinalIgnoreCase ) )
			{
				throw new ArgumentOutOfRangeException( "Invalid folder name!", "folderName" );
			}

			ViewGalleryVM model = new ViewGalleryVM
			{
				Title = folderName,
				PhotoUrls = new List<string>()
			};

			// Enumerate the files in the requested folder.
			IEnumerable<string> photoUrls = Directory.EnumerateFiles( folderPhysicalPath, "*.jpg" ).Select( filePhysicalPath => Path.Combine( folderVirtualPath, Path.GetFileName( filePhysicalPath ) ) );
			model.PhotoUrls.AddRange( photoUrls );

			return View( model );
		}

	}
}