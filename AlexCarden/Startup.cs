using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlexCarden.Startup))]
namespace AlexCarden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
