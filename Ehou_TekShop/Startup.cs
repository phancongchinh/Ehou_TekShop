using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ehou_TekShop.Startup))]
namespace Ehou_TekShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
