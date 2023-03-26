using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ambit.Common;
//using AmbitWebAPI.Scheduler;

namespace AmbitWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            //ContainerBuilder builder = new ContainerBuilder();
            //IContainer container = Bootstrapper.Resolve(builder);
            ContainerBuilder builder = new ContainerBuilder();
            IContainer container = Bootstrapper.Resolve(builder);
            //NLog.Config.ConfigurationItemFactory.Default.LayoutRenderers.RegisterDefinition("mdlc", typeof(MdlcLayoutRenderer));
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
            //Bootstrapper.Resolve(builder);

            
            //PaperSetScheduler.Start(container);
        }

        protected void Application_Error()
        {
            //Code that runs when an unhandled error occurs
            Exception ErrorInfo = Server.GetLastError().GetBaseException();
            CommonHelper.LogError(Server.MapPath("~/ErrorLog/ErrorLog.txt"), ErrorInfo);
            Server.ClearError();
            //if (Request.RequestContext.RouteData.DataTokens["area"] != null && Request.RequestContext.RouteData.DataTokens["area"].ToString().ToLower() == Pages.Areas.Admin.ToLower())
            //    Response.Redirect(CommonHelper.UrlBase + Pages.Areas.Admin + "/" + Pages.Controllers.Account + "/" + Pages.Actions.Error);
            //else
            //    Response.Redirect(CommonHelper.UrlBase + Pages.Controllers.Account + "/" + Pages.Actions.Error);
        }
    }
}
