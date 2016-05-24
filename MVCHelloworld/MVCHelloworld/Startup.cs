using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHelloworld.Startup))]
namespace MVCHelloworld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
