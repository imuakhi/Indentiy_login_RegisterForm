using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M5C11_W01.Startup))]
namespace M5C11_W01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
