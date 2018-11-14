using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GpaoRntaProject.Startup))]
namespace GpaoRntaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
