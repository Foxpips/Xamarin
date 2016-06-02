using Autofac;
using ColourTester.Modules;
using ColourTester.Pages;
using Xamarin.Forms;

namespace ColourTester
{
    public class App : Application
    {
        public App()
        {
            //            builder.RegisterModule<ColourTesterModule>();
//            builder.RegisterModule<ApplicationModule>();

            var injector = new Injector();
            var container= injector.RegisterModulesOnInit();

//            var container = builder.Build();
            using (container.BeginLifetimeScope())
            {
                var landing = container.Resolve<ColourView>();

                MainPage = new NavigationPage(landing);
            }

            // The root page of your application
            //            MainPage = new ContentPage
            //            {
            //                Content = new StackLayout
            //                {
            //                    VerticalOptions = LayoutOptions.Center,
            //                    Children = {
            //                        new Label {
            //                            XAlign = TextAlignment.Center,
            //                            Text = "Welcome to Xamarin Forms!",
            //                            TextColor = Color.Aqua
            //                        }
            //                    }
            //                }
            //            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
