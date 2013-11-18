using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SimplestAuth.Startup))]

namespace SimplestAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuthentication(app);
        }
    }
}