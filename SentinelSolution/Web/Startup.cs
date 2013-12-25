using System.Diagnostics.CodeAnalysis;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute( typeof( Sentinel.Web.Startup ) )]
namespace Sentinel.Web
{
	public partial class Startup
	{
		[SuppressMessage( "Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "app", Justification = "Required by OWIN." )]
		[SuppressMessage( "Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required by OWIN." )]
		public void Configuration( IAppBuilder app )
		{
		}
	}
}
