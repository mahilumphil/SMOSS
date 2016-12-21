using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SystemProject.Startup))]
namespace SystemProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
