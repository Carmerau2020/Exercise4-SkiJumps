using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkiingJumps.Startup))]
namespace SkiingJumps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
