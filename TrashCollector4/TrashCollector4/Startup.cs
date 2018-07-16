using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollector4.Startup))]
namespace TrashCollector4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
