using Microsoft.Owin;
using TemplateProject.Web;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace TemplateProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAutofac(app);
            ConfigureAuth(app);
        }
    }
}
