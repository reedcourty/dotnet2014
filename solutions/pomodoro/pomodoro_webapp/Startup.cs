using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pomodoro_webapp.Startup))]
namespace pomodoro_webapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
