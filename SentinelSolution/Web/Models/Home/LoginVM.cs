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


		[Required( ErrorMessage = "Add meg a felhasználónevet!" )]
		[Display( Name = "Felhasználónév" )]
		public string UserName { get; set; }

		[Required( ErrorMessage = "Add meg a jelszót!" )]
		[DataType( DataType.Password )]
		[Display( Name = "Jelszó" )]
		public string Password { get; set; }

		[Display( Name = "Emlékezz rám" )]
		public bool RememberMe { get; set; }
	}
}
