using Autofac;
using LoteriaApi.Models;

namespace LoteriaApi.App_Start
{
    public class AutoFacConfig
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            var webApiAssembly = typeof(Card).Assembly;

            builder.RegisterAssemblyTypes(webApiAssembly).Where(type => type.Name.EndsWith("Controller")).AsSelf();
            builder.RegisterAssemblyTypes(webApiAssembly).AsImplementedInterfaces();

            return builder.Build();
        }
    }
}