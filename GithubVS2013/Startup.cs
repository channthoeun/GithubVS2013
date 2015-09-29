using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubVS2013.Startup))]
namespace GithubVS2013
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
