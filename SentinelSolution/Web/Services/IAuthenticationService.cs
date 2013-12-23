namespace Sentinel.Web.Services
{
	using System.Diagnostics.Contracts;


	/// <summary>
	/// Contract for service components which encapsulate the details of the authentication.
	/// </summary>
	[ContractClass( typeof( AuthenticationServiceContract ) )]
	public interface IAuthenticationService
	{
		/// <summary>
		/// Logs in the user.
		/// </summary>
		/// <param name="userName">The login name of the user who tries to log in.</param>
		/// <param name="password">The password to use to try to authenticate the user.</param>
		/// <param name="isPersistent">If set to <c>true</c> then a persistent authentication cookie is created; if <c>false</c> then the cookie will have only session lifetime.</param>
		/// <returns><c>True</c> if the specified <paramref name="userName"/> and <paramref name="password"/> is correct, and the user successfully authenticated.</returns>
		bool SignIn( string userName, string password, bool isPersistent );


		/// <summary>
		/// Logs out the currently authenticated in user.
		/// </summary>
		void SignOut();
	}
}
