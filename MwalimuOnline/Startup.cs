using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MwalimuOnline.Startup))]
namespace MwalimuOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
