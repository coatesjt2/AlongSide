using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlongSide.Startup))]
namespace AlongSide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
