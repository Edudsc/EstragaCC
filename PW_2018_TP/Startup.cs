using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PW_2018_TP.Startup))]
namespace PW_2018_TP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
