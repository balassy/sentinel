using System.Diagnostics.Contracts;

namespace Sentinel.Web.Controllers
{
	using System.Web.Mvc;
	using System.Web.Security;
	using Sentinel.Web.Models.Home;
	using Sentinel.Web.Services;


	public partial class HomeController : Controller
	{
		public virtual ActionResult Index()
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
			Contract.Requires( model != null );

			if( ModelState.IsValid )
			{
				AuthenticationService auth = new AuthenticationService();
				bool isAuthenticated = auth.SignIn( model.UserName, model.Password, model.RememberMe );

				if( isAuthenticated )
				{
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
			AuthenticationService auth = new AuthenticationService();
			auth.SignOut();

			return RedirectToAction( MVC.Home.Login() );
		}

	}
}