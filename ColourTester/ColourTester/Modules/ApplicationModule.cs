using Autofac;
using ColourTester.Pages;

namespace ColourTester.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LandingView>().SingleInstance();
        }
    }
}