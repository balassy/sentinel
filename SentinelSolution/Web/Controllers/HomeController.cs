namespace Sentinel.Web.Controllers
{
	using System.Web.Mvc;
	using System.Web.Security;
	using Sentinel.Web.Models.Home;


	public partial class HomeController : Controller
	{
		public virtual ActionResult Index( string returnUrl )
		{
			return this.RedirectToActionPermanent( MVC.Gallery.ViewGalleries() );
		}


		public virtual ActionResult Login( string returnUrl )
		{
			ViewBag.ReturnUrl = returnUrl;
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Login( LoginVM model, string returnUrl )
		{
			if( ModelState.IsValid )
			{
				bool isAuthenticated = FormsAuthentication.Authenticate( model.UserName, model.Password );

				if( isAuthenticated )
				{
					FormsAuthentication.SetAuthCookie( model.UserName, model.RememberMe );
					return Url.IsLocalUrl( returnUrl )
						? (ActionResult) Redirect( returnUrl )
						: RedirectToAction( MVC.Gallery.ViewGalleries() );
				}
				else
				{
					ModelState.AddModelError( "", "Ajjaj, így nem fogsz bejutni!" );
				}
			}

			return View( model );
		}



		[HttpPost]
		[Authorize]
		[ValidateAntiForgeryToken]
		public virtual ActionResult LogOff()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction( MVC.Home.Login() );
		}

	}
}