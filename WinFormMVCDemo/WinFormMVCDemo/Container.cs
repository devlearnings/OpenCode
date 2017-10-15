using Autofac;
using WinFormMVCDemo.Controllers;
using WinFormMVCDemo.Orchestrator;
using WinFormMVCDemo.Repository;

namespace WinFormMVCDemo
{
    public static class DependencyContainer
    {
        public static IContainer Container;

        public static void BuildDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PersonWriteRepository>().As<IPersonWriteRepository>();
            builder.RegisterType<PersonReadRepository>().As<IPersonReadRepository>();
            builder.RegisterType<PersonOrchestrator>().As<IPersonOrchestrator>();
            builder.RegisterType<PersonController>().As<IPersonController>();
            builder.RegisterType<HomeController>().As<IHomeController>();

            Container = builder.Build();
        }

    }
}
