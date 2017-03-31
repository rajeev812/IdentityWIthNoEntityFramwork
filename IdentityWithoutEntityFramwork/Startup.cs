using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityWithoutEntityFramwork.Startup))]
namespace IdentityWithoutEntityFramwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
