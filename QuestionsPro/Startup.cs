using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestionsPro.Startup))]
namespace QuestionsPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
