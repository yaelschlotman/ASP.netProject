using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.netProject.Startup))]
namespace ASP.netProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
