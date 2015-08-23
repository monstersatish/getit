using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetIt.Startup))]
namespace GetIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
