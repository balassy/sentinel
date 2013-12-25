namespace Sentinel.Web.Services
{
	using System.Configuration;
	using System.Diagnostics.Contracts;
	using Sentinel.Web.Config;


	/// <summary>
	/// Service component which encapsulates the configuration settings.
	/// </summary>
	public class ConfigService : IConfigService
	{
		/// <summary>
		/// Store the reference to the <c>Galleries</c> section.
		/// </summary>
		private readonly GalleriesSection galleriesSection;


		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigService"/> class.
		/// </summary>
		public ConfigService()
		{
			Contract.Ensures( this.galleriesSection != null );
			this.galleriesSection = ConfigurationManager.GetSection( @"Sentinel/Galleries" ) as GalleriesSection;
		}

		/// <summary>
		/// Gets the application realtive virtual path of the folder which contains the galleries.
		/// </summary>
		public string StorageFolderVirtualPath
		{
			get
			{
				return this.galleriesSection.StorageFolderVirtualPath;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the gallery thumbnails should be automatically generated.
		/// </summary>
		public bool AutoGenerateThumbnails
		{
			get
			{
				return this.galleriesSection.AutoGenerateThumbnails;
			}
		}
	}
}