using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialSite.Startup))]
namespace SocialSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
