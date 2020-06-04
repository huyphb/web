using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTapLab.Startup))]
namespace BaiTapLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
