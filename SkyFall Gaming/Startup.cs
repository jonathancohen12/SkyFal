using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyFall_Gaming.Startup))]
namespace SkyFall_Gaming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
