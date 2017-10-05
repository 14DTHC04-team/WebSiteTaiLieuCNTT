using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLTaiLieuCNTT.Startup))]
namespace QLTaiLieuCNTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
