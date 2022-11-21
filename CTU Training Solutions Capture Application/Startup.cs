using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTU_Training_Solutions_Capture_Application.Startup))]
namespace CTU_Training_Solutions_Capture_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
