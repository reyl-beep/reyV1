using Nancy;
using Nancy.Bootstrapper;
using Nancy.Configuration;
using Nancy.Diagnostics;
using Nancy.TinyIoc;
using ReyV1.Api.Infrastructure;

namespace ReyV1.Api
{
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            pipelines.AfterRequest.AddItemToEndOfPipeline(ctx =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*");
                ctx.Response.WithHeader("Access-Control-Allow-Methods", "GET,POST,PUT,DELETE,OPTIONS");
                ctx.Response.WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
            });
        }

        public override void Configure(INancyEnvironment environment)
        {
            environment.Diagnostics(true, "password");
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register(AppSettingsProvider.Load()).AsSingleton();
        }
    }
}
