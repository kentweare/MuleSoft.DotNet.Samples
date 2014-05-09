using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuleSoft.DotNet.PayrollWebSite.Startup))]
namespace MuleSoft.DotNet.PayrollWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
