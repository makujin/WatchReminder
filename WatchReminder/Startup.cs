using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatchReminder.Startup))]
namespace WatchReminder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
