using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TiendaMVC.DAL;
using TiendaMVC.IFR;
using TiendaMVC.Web.App_Start;

namespace TiendaMVC.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ApplicationDbContext context = new DAL.ApplicationDbContext();
            var products = context.Products;
            IoCConfig.Configure();

            AutomapperConfig.Configure();

        }

        void Application_Error(Object sender, EventArgs e) {
            Exception ex = Server.GetLastError();
            Log.WriteFatal(ex.Message, ex);
        }
    }
}
