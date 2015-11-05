using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectSchool.Startup))]
namespace ProjectSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
