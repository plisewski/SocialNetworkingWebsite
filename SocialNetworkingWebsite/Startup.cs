using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialNetworkingWebsite.Startup))]
namespace SocialNetworkingWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
