using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity_IntPrimaryKey.Startup))]
namespace Identity_IntPrimaryKey
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
