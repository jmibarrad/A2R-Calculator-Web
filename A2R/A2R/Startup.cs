using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A2R.Startup))]
namespace A2R
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
