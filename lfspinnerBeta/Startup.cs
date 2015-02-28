using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lfspinnerBeta.Startup))]
namespace lfspinnerBeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
