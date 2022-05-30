using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuongGiaBao_Bigschool.Startup))]
namespace DuongGiaBao_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
