﻿namespace Sentinel.Web.Controllers
{
	using System.Web.Mvc;
	using System.Web.Security;
	using Sentinel.Web.Models.Home;


	public class HomeController : Controller
	{
		public ActionResult Index( string returnUrl )
		{
			return this.RedirectToActionPermanent( "ViewGalleries", "Gallery" );
		}
		

		public ActionResult Login( string returnUrl )
		{
			ViewBag.ReturnUrl = returnUrl;
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login( LoginVM model, string returnUrl )
		{
			if( ModelState.IsValid )
			{
				bool isAuthenticated = FormsAuthentication.Authenticate( model.UserName, model.Password );

				if( isAuthenticated )
				{
					FormsAuthentication.SetAuthCookie( model.UserName, model.RememberMe );
					return Url.IsLocalUrl( returnUrl )
						? (ActionResult) Redirect( returnUrl )
						: RedirectToAction( "ViewGalleries", "Gallery" );
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
		public ActionResult LogOff()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction( "Login", "Home" );
		}

	}
}