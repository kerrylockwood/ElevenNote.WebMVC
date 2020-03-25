using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElevenNoteWeb.MVC.Startup))]
namespace ElevenNoteWeb.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
