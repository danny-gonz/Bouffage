using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bouffage.Startup))]
namespace Bouffage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
