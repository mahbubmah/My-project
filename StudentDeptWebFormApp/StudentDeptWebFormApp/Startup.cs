using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentDeptWebFormApp.Startup))]
namespace StudentDeptWebFormApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
