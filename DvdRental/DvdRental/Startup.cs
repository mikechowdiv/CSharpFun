using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DvdRental.Startup))]
namespace DvdRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
