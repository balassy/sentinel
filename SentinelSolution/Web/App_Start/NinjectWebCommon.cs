[assembly: WebActivator.PreApplicationStartMethod( typeof( Sentinel.Web.NinjectWebCommon ), "Start" )]
[assembly: WebActivator.ApplicationShutdownMethodAttribute( typeof( Sentinel.Web.NinjectWebCommon ), "Stop" )]

namespace Sentinel.Web
{
	using System;
	using System.Diagnostics.Contracts;
	using System.Web;
	using Sentinel.Web.Services;

	using Microsoft.Web.Infrastructure.DynamicModuleHelper;

	using Ninject;
	using Ninject.Web.Common;


	/// <summary>
	/// Encapsulates the details of setting up dependency injection when the application is started.
	/// </summary>
	public static class NinjectWebCommon
	{
		private static readonly Bootstrapper bootstrapper = new Bootstrapper();


		/// <summary>
		/// Starts the application.
		/// </summary>
		public static void Start()
		{
			DynamicModuleUtility.RegisterModule( typeof( OnePerRequestHttpModule ) );
			DynamicModuleUtility.RegisterModule( typeof( NinjectHttpModule ) );
			bootstrapper.Initialize( CreateKernel );
		}

		/// <summary>
		/// Stops the application.
		/// </summary>
		public static void Stop()
		{
			bootstrapper.ShutDown();
		}

		/// <summary>
		/// Creates the kernel that will manage your application.
		/// </summary>
		/// <returns>The created kernel.</returns>
		private static IKernel CreateKernel()
		{
			var kernel = new StandardKernel();
			kernel.Bind<Func<IKernel>>().ToMethod( ctx => () => new Bootstrapper().Kernel );
			kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

			RegisterServices( kernel );
			return kernel;
		}

		/// <summary>
		/// Load your modules or register your services here!
		/// </summary>
		/// <param name="kernel">The kernel.</param>
		private static void RegisterServices( IKernel kernel )
		{
			Contract.Requires( kernel != null );

			kernel.Bind<IAuthenticationService>().To<AuthenticationService>();
			kernel.Bind<IConfigService>().To<ConfigService>();
			kernel.Bind<IImageService>().To<ImageService>();
		}
	}
}
