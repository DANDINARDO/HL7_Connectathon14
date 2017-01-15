using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HL7_CDASH_Web.Startup))]
namespace HL7_CDASH_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
