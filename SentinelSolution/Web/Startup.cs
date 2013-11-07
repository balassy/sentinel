using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute( typeof( Sentinel.Web.Startup ) )]
namespace Sentinel.Web
{
	public partial class Startup
	{
		public void Configuration( IAppBuilder app )
		{
		}
	}
}
