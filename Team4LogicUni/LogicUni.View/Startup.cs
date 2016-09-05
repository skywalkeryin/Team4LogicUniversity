using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogicUni.View.Startup))]
namespace LogicUni.View
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
