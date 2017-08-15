using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingCartSnippet.Startup))]
namespace shoppingCartSnippet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
