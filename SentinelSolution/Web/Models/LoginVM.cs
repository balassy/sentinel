namespace Sentinel.Web.Models
{
	using System.ComponentModel.DataAnnotations;


	public class LoginVM
	{
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
