using Autofac;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(AutofacExample.Startup))]
namespace AutofacExample
{
    
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());
            DependencyResolver.SetResolver(resolver);

            // http://scottdorman.github.io/2016/03/17/integrating-asp.net-core-dependency-injection-in-mvc-4/

            //var builder = new ContainerBuilder();
            //builder.RegisterType<TestService>().As<ITestService>();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // todo: create services and add here

            services.AddMediatR(typeof(Startup));
        }

        
    }
}