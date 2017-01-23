using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndrewPechaWebApp.Startup))]
namespace AndrewPechaWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
