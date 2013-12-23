namespace Sentinel.Web.Services
{
	using System;
	using System.Diagnostics.Contracts;
	using System.Web.Security;


	/// <summary>
	/// Service component that encapsulates the details of the authentication.
	/// </summary>
	public class AuthenticationService : IAuthenticationService
	{
		/// <summary>
		/// Logs in the user.
		/// </summary>
		/// <param name="userName">The login name of the user who tries to log in.</param>
		/// <param name="password">The password to use to try to authenticate the user.</param>
		/// <param name="isPersistent">If set to <c>true</c> then a persistent authentication cookie is created; if <c>false</c> then the cookie will have only session lifetime.</param>
		/// <returns><c>True</c> if the specified <paramref name="userName"/> and <paramref name="password"/> is correct, and the user successfully authenticated.</returns>
		public bool SignIn( string userName, string password, bool isPersistent )
		{
			Contract.Requires( !String.IsNullOrEmpty( userName ) );
			Contract.Requires( !String.IsNullOrEmpty( password ) );

// CS0618: 'System.Web.Security.FormsAuthentication.Authenticate(string, string)' is obsolete: 'The recommended alternative is to use the Membership APIs, such as Membership.ValidateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.'
// NOTE: This is required, becuase the Membership API does not support storing the credentials in the web.config.
#pragma warning disable 618
			bool isAuthenticated = FormsAuthentication.Authenticate( userName, password );
#pragma warning restore 618

			if( isAuthenticated )
			{
				FormsAuthentication.SetAuthCookie( userName, isPersistent );
			}

			return isAuthenticated;
		}


		/// <summary>
		/// Logs out the currently authenticated in user.
		/// </summary>
		/// <remarks>
		/// This method can be called without any side effect even if currently the user is not logged in.
		/// </remarks>
		public void SignOut()
		{
			FormsAuthentication.SignOut();
		}

	}
}