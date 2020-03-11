using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(schoolreg.Startup))]
namespace schoolreg
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
