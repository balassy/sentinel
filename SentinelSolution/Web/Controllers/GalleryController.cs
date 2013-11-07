namespace Sentinel.Web.Controllers
{
	using System.Web.Mvc;


	[Authorize]
	public class GalleryController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

	}
}