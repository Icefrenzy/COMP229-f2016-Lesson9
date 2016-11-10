using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP229_f2016_Lesson9.Startup))]
namespace COMP229_f2016_Lesson9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
