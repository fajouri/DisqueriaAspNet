using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DisqueriaAspNet.Startup))]
namespace DisqueriaAspNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
