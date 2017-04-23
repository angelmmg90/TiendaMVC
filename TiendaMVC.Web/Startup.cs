using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaMVC.Web.Startup))]
namespace TiendaMVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
