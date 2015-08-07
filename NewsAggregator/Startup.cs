using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsAggregator.Startup))]
namespace NewsAggregator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
