using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test123.Startup))]
namespace Test123
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
