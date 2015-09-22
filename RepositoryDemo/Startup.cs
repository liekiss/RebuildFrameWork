using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryDemo.Startup))]
namespace RepositoryDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
