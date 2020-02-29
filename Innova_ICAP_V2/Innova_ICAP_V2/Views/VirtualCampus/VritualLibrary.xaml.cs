using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Innova_ICAP_V2.Views.VirtualCampus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VritualLibrary : ContentPage
    {
        public VritualLibrary()
        {
            InitializeComponent();
            Webview.Source = "http://opac.icap.ac.cr/CatalogoBasico/";
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