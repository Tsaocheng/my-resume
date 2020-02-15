using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MP.Web.Minipig.Startup))]
namespace MP.Web.Minipig
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
