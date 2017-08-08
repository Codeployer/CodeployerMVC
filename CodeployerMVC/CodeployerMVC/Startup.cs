using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeployerMVC.Startup))]
namespace CodeployerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
