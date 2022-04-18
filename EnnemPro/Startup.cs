using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnnemPro.Startup))]
namespace EnnemPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
