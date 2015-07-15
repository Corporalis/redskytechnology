using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedSkyTechnology.Web.Startup))]
namespace RedSkyTechnology.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
