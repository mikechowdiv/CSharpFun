using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShackUp2017.UI.Startup))]
namespace ShackUp2017.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
