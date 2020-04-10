using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_MVC_5.Startup))]
namespace Vidly_MVC_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
