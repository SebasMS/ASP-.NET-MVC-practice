using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspSMTutorial.Startup))]
namespace aspSMTutorial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
