using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschools__2.Startup))]
namespace Bigschools__2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
