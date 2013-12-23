using Sentinel.Web.Resources.Home;

namespace Sentinel.Web.Models.Home
{
	using System.ComponentModel.DataAnnotations;


	public class LoginVM
	{
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
