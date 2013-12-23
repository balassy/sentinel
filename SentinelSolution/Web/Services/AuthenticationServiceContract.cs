namespace Sentinel.Web.Services
{
	using System;
	using System.Diagnostics.Contracts;


	/// <summary>
	/// Metadata class that contains the Code Contracts for the <see cref="IAuthenticationService"/> interface.
	/// </summary>
	[ContractClassFor( typeof( IAuthenticationService ) )]
	public abstract class AuthenticationServiceContract : IAuthenticationService
	{
		public bool SignIn( string userName, string password, bool isPersistent )
		{
			Contract.Requires( !String.IsNullOrEmpty( userName ) );
			Contract.Requires( !String.IsNullOrEmpty( password ) );

			return default( bool );
		}


		public void SignOut()
		{
		}
	}
}