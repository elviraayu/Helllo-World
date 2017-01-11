using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_09_XIRPL3_ElviraAyuSosilia_HelloWorld.Startup))]
namespace _09_XIRPL3_ElviraAyuSosilia_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
