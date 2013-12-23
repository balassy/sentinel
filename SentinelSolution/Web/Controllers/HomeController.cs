namespace Sentinel.Web.Controllers
{
	using System;
	using System.Diagnostics.Contracts;
	using System.Web.Mvc;
	using Sentinel.Web.Models.Home;
	using Sentinel.Web.Services;

	using Ninject;


	public partial class HomeController : Controller
	{
		[Inject]
		public IAuthenticationService AuthenticationService { get; set; }


		public virtual ActionResult Index()
		{
			return this.RedirectToActionPermanent( MVC.Gallery.ViewGalleries() );
		}


		public virtual ActionResult Login( string returnUrl )
		{
			this.ViewBag.ReturnUrl = returnUrl;
			return this.View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Login( LoginVM model, string returnUrl )
		{
			Contract.Requires( model != null );

			if( this.ModelState.IsValid )
			{
				bool isAuthenticated = this.AuthenticationService.SignIn( model.UserName, model.Password, model.RememberMe );

				if( isAuthenticated )
				{
					return this.Url.IsLocalUrl( returnUrl )
						? (ActionResult) this.Redirect( returnUrl )
						: this.RedirectToAction( MVC.Gallery.ViewGalleries() );
				}
				else
				{
					this.ModelState.AddModelError( String.Empty, "Ajjaj, így nem fogsz bejutni!" );
				}
			}

			return this.View( model );
		}



		[HttpPost]
		[Authorize]
		[ValidateAntiForgeryToken]
		public virtual ActionResult LogOff()
		{
			this.AuthenticationService.SignOut();

			return this.RedirectToAction( MVC.Home.Login() );
		}

	}
}