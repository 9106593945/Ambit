// ----------------------------------------------------------------------
// <copyright file="bootstrapper.cs" company="">
//     Copyright statement. All right reserved
// </copyright>
//
// ------------------------------------------------------------------------

namespace AmbitWebAPI
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using Autofac.Integration.WebApi;
    using Ambit.Services;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;

    //using AmbitWebAPI.Job;

    /// <summary>
    /// Bootstrap Class
    /// </summary>
    internal sealed class Bootstrapper
    {
        /// <summary>
        /// Resolves the specified builder.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public static IContainer Resolve(ContainerBuilder builder)
        {
            if (HttpContext.Current != null)
            {
                builder.Register(c =>
                                 new HttpContextWrapper(HttpContext.Current) as HttpContextBase)
                .As<HttpContextBase>()
                .InstancePerDependency();
            }
            builder.Register(c => c.Resolve<HttpContextBase>().Request)
            .As<HttpRequestBase>()
            .InstancePerDependency();
            builder.Register(c => c.Resolve<HttpContextBase>().Response)
            .As<HttpResponseBase>()
            .InstancePerDependency();
            builder.Register(c => c.Resolve<HttpContextBase>().Server)
            .As<HttpServerUtilityBase>()
            .InstancePerDependency();
            builder.Register(c => c.Resolve<HttpContextBase>().Session)
            .As<HttpSessionStateBase>()
            .InstancePerDependency();

            builder.RegisterControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterModule<ServiceModule>();
            // builder.RegisterModule<ElasticModule>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //// Create the dependency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);

            //// Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            return container;
        }
    }
}