using SimpleInjector;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApp.CrossCutting;
using WebApp.Service;

namespace WebApp.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            new WebApp.Service.DatabaseConfigure(ConfigurationManager.ConnectionStrings["database"].ConnectionString,  new[] { "Cliente" });

            Container container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            SimpleInjectorConfiguration.Register(container);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.RegisterMvcIntegratedFilterProvider();

            AutoMapperConfig.RegisterMapping();
            DependencyResolver.SetResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            container.Verify();
        }
    }
}
