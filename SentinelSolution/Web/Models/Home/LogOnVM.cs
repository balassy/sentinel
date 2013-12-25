namespace Sentinel.Web.Models.Home
{
	using System.ComponentModel.DataAnnotations;
	using Sentinel.Web.Resources.Home;


	/// <summary>
	/// The view-model for the login page.
	/// </summary>
	public sealed class LogOnVM
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LogOnVM"/> class.
		/// </summary>
		public LogOnVM()
		{
			// NOTE: If you want to use multiple users, remove this constructor.
			this.UserName = "demo";
		}


		[Display( ResourceType = typeof( LogOnRes ), Name = "UserName" )]
		[Required( ErrorMessageResourceType = typeof( LogOnRes ), ErrorMessageResourceName = "UserNameRequired" )]
		public string UserName { get; set; }

		[DataType( DataType.Password )]
		[Display( ResourceType = typeof( LogOnRes ), Name = "Password" )]
		[Required( ErrorMessageResourceType = typeof( LogOnRes ), ErrorMessageResourceName = "PasswordRequired" )]
		public string Password { get; set; }

		[Display( ResourceType = typeof( LogOnRes ), Name = "RememberMe" )]
		public bool RememberMe { get; set; }
	}
}
