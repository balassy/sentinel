namespace Sentinel.Web.Controllers
{
	using System.Web.Mvc;
	using System.Web.Security;
	using Sentinel.Web.Models.Home;


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
			if( ModelState.IsValid )
			{
// CS0618: 'System.Web.Security.FormsAuthentication.Authenticate(string, string)' is obsolete: 'The recommended alternative is to use the Membership APIs, such as Membership.ValidateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.'
// NOTE: This is required, becuase the Membership API does not support storing the credentials in the web.config.
#pragma warning disable 618
				bool isAuthenticated = FormsAuthentication.Authenticate( model.UserName, model.Password );
#pragma warning restore 618

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