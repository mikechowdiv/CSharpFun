using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NinjectMvc.Startup))]
namespace NinjectMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
