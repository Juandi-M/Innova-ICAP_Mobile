using Innova_ICAP_V2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Innova_ICAP_V2
{
    public partial class App : Application
    {
        public static object Navigation { get; internal set; }

        public App()
        {
            MainPage = new NavigationPage(new HomeScreen());
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
