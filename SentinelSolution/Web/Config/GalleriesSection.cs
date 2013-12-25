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


		/// <summary>
		/// Gets a value indicating whether the gallery thumbnails should be automatically generated.
		/// </summary>
		/// <value><c>True</c> if thumbnails should be automatically generated; otherwise, <c>false</c>.</value>
		[ConfigurationProperty( "autoGenerateThumbnails", IsRequired = true, DefaultValue = true )]
		public bool AutoGenerateThumbnails
		{
			get
			{
				return (bool) this[ "autoGenerateThumbnails" ];
			}
		}
	}
}