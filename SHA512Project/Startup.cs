using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SHA512Project.Startup))]
namespace SHA512Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
