using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NaturalPowerWindTurbines.Startup))]
namespace NaturalPowerWindTurbines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
