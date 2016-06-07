using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCopdracht.Startup))]
namespace MVCopdracht
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
