using Autofac;
using ColourTester.Pages;
using ColourTester.Services;
using ColourTester.ViewModels;

namespace ColourTester.Modules
{
    public class ColourTesterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ColourDataService>().As<IColourDataService>().SingleInstance();
            builder.RegisterType<ColourViewModel>();
            builder.RegisterType<ColourCollectionViewModel>().SingleInstance();
            builder.RegisterType<ColourView>().SingleInstance();
        }
    }
}