using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Intex2.Startup))]
namespace Intex2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
