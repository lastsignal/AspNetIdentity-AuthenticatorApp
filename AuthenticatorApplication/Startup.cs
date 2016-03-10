using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticatorApplication.Startup))]
namespace AuthenticatorApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
