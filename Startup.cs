using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(storedata.Startup))]
namespace storedata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
