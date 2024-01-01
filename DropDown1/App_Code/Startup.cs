using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropDown1.Startup))]
namespace DropDown1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
