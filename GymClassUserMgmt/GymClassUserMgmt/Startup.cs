using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymClassUserMgmt.Startup))]
namespace GymClassUserMgmt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
