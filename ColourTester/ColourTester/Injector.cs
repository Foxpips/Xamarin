using System;
using System.Linq;
using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace ColourTester
{
    public class Injector
    {
        public IContainer InitialiseAutoFac(ContainerBuilder builder = null)
        {
            var containerBuilder = builder ?? new ContainerBuilder();
            var exportedTypes = GetType().GetTypeInfo().Assembly.ExportedTypes;

            foreach (var source in exportedTypes.Where(x => x.IsAssignableTo<Module>()))
            {
                var instance = (Module)Activator.CreateInstance(source);
                var methodInfos = typeof(Module).GetRuntimeMethods();

                var methodInfo = methodInfos.Single(x => x.Name.Equals("Load"));
                methodInfo.Invoke(instance, new object[] { containerBuilder });
            }

            return containerBuilder.Build();
        }

        public IContainer RegisterModulesOnInit(ContainerBuilder builder = null)
        {
            var containerBuilder = builder ?? new ContainerBuilder();
            var modules = GetType().GetTypeInfo().Assembly.ExportedTypes.Where(type=>type.IsAssignableTo<Module>());

            foreach (var module in modules)
            {
                var instance = (Module)Activator.CreateInstance(module);
                containerBuilder.RegisterModule(instance);
            }

            return containerBuilder.Build();
        }
    }
}