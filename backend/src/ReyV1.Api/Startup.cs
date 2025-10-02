using Nancy.Owin;
using Owin;

namespace ReyV1.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy(options => options.Bootstrapper = new CustomBootstrapper());
        }
    }
}
