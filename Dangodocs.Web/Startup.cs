using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dangodocs.Web.Startup))]
namespace Dangodocs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
