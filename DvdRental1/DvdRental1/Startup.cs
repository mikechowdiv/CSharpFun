using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DvdRental1.Startup))]
namespace DvdRental1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
