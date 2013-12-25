namespace Sentinel.Web.Config
{
	using System.Configuration;


	/// <summary>
	/// Represents the <c>Virgo/Galleries</c> section in the configuration file.
	/// </summary>
	public class GalleriesSection : ConfigurationSection
	{
		/// <summary>
		/// Gets the application relative virtual path of the folder which contains the galleries.
		/// </summary>
		[ConfigurationProperty( "storageFolderVirtualPath", IsRequired = true, DefaultValue = "~/Photos" )]
		public string StorageFolderVirtualPath
		{
			get
			{
				return (string) this[ "storageFolderVirtualPath" ];
			}
		}
	}
}