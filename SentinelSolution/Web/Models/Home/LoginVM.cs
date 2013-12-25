namespace Sentinel.Web.Models.Home
{
	using System.ComponentModel.DataAnnotations;
	using Sentinel.Web.Resources.Home;


	/// <summary>
	/// The view-model for the login page.
	/// </summary>
	public class LoginVM
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LoginVM"/> class.
		/// </summary>
		public LoginVM()
		{
			// NOTE: If you want to use multiple users, remove this constructor.
			this.UserName = "demo";
		}


		[Display( ResourceType = typeof( LoginRes ), Name = "UserName" )]
		[Required( ErrorMessageResourceType = typeof( LoginRes ), ErrorMessageResourceName = "UserNameRequired" )]
		public string UserName { get; set; }

		[DataType( DataType.Password )]
		[Display( ResourceType = typeof( LoginRes ), Name = "Password" )]
		[Required( ErrorMessageResourceType = typeof( LoginRes ), ErrorMessageResourceName = "PasswordRequired" )]
		public string Password { get; set; }

		[Display( ResourceType = typeof( LoginRes ), Name = "RememberMe" )]
		public bool RememberMe { get; set; }
	}
}
