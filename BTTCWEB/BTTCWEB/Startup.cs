using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTTCWEB.Startup))]
namespace BTTCWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
