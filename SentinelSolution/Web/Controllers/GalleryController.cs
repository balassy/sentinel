namespace Sentinel.Web.Controllers
{
	using System.Collections.Generic;
	using System.Web.Mvc;
	using Sentinel.Web.Models.Gallery;


	[Authorize]
	public class GalleryController : Controller
	{
		public ActionResult ViewGalleries()
		{
			ViewGalleriesVM model = new ViewGalleriesVM
			{
				Series = new List<SeriesVM>
				{
					new SeriesVM { Title = "2013-11-01 Sed ut perspiciatis unde omnis ", Count = 7, FolderName = "First", ThumbnailUrl = "~/Photos/First/img2.jpg" },
					new SeriesVM { Title = "2013-11-01 Neque porro quisquam est autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae ", Count = 37, FolderName = "Second", ThumbnailUrl = "~/Photos/Second/img5.jpg" },
					new SeriesVM { Title = "2013-11-01 Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur ", Count = 148, FolderName = "Third", ThumbnailUrl =  "~/Photos/Third/img3.jpg" }
				}
			};

			return View( model );
		}


		public ActionResult ViewGallery( string folderName )
		{
			return View();
		}

	}
}