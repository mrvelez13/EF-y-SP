using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seguimiento5.Startup))]
namespace Seguimiento5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
