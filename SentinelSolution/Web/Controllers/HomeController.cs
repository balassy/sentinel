﻿namespace Sentinel.Web.Controllers
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Diagnostics.Contracts;
	using System.Web.Mvc;
	using Sentinel.Web.Models.Home;
	using Sentinel.Web.Services;
	using Sentinel.Web.Resources.Home;

	using Ninject;


	public partial class HomeController : Controller
	{
		[Inject]
		public IAuthenticationService AuthenticationService { get; set; }


		public virtual ActionResult Index()
		{
			return this.RedirectToActionPermanent( MVC.Gallery.ViewGalleries() );
		}


		[SuppressMessage( "Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId="0#", Justification = "Always used as a whole string, never parsed." )]
		public virtual ActionResult LogOn( string returnUrl )
		{
			this.ViewBag.ReturnUrl = returnUrl;
			return this.View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		[SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "False alarm, because Code Analysis does not recognize Code Contracts." )]
		[SuppressMessage( "Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "Always used as a whole string, never parsed." )]
		public virtual ActionResult LogOn( LogOnVM model, string returnUrl )
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
					this.ModelState.AddModelError( String.Empty, LogOnRes.InvalidCredentialsError );
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

			return this.RedirectToAction( MVC.Home.LogOn() );
		}

	}
}