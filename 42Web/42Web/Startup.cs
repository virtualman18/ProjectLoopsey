using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_42Web.Startup))]
namespace _42Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
