using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Innova_ICAP_V2.Views.AboutUs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Blog : ContentPage
    {
        public Blog()
        {
            InitializeComponent();

            Webview.Source = "https://icap.ac.cr/blogicap_principal/";
            //Webview.Source = "https://www.google.com";
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            //progress bar
            progress.IsVisible = true;

            // Activy indicator (Spinners)
            activity.IsEnabled = true;
            activity.IsRunning = true;
            activity.IsVisible = true;
        }

        protected void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            //progress bar
            progress.IsVisible = false;

            // Activy indicator (Spinners)
            activity.IsEnabled = false;
            activity.IsRunning = false;
            activity.IsVisible = false;
        }
    }
}