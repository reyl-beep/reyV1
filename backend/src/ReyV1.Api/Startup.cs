using Microsoft.Owin.Builder;
using Nancy.Owin;
using Owin;

namespace ReyV1.Api
{
    public class Startup
    {
        public void Configuration(AppBuilder app)
        {
            app.UseNancy(options => options.Bootstrapper = new CustomBootstrapper());
        }
    }
}
