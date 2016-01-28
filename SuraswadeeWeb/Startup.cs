using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuraswadeeWeb.Startup))]
namespace SuraswadeeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
