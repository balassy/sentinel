namespace Sentinel.Web.Services
{
	using System;
	using System.Diagnostics.Contracts;


	/// <summary>
	/// Metadata class that contains the Code Contracts for the <see cref="IConfigService"/> interface.
	/// </summary>
	[ContractClassFor( typeof( IConfigService ) )]
	public abstract class ConfigServiceContract : IConfigService
	{
		public string StorageFolderVirtualPath
		{
			get
			{
				Contract.Ensures( !String.IsNullOrEmpty( Contract.Result<string>() ) );
				return default( string );
			}
		}
	}
}