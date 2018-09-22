using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoolLeague.Startup))]
namespace PoolLeague
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
