using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerOnlineShopping.Startup))]
namespace FlowerOnlineShopping
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
