using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WOTAPI.WebMVC.Startup))]
namespace WOTAPI.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
