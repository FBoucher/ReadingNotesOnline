using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadingNotesOnline.Startup))]
namespace ReadingNotesOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
