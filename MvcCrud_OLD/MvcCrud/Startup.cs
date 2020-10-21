using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCrud.Startup))]
namespace MvcCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
