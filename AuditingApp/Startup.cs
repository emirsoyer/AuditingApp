using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DummyIndividualAuth.Startup))]
namespace DummyIndividualAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
