using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemixReview.Startup))]
namespace RemixReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
