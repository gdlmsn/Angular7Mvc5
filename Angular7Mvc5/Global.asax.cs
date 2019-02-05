using Angular7Mvc5.App_Start;
using Angular7Mvc5.Controllers.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Angular7Mvc5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            
            //setup api controller
            GlobalConfiguration.Configure(WebApiConfig.Register);

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //add script and content bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //load all data
            SystemController.Instance.LoadData();
        }
    }
}
