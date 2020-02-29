using Innova_ICAP_V2.Views.AboutUs;
using Innova_ICAP_V2.Views.Events;
using Innova_ICAP_V2.Views.VirtualCampus;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace Innova_ICAP_V2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeScreen : ContentPage
    {

        //Label resultsLabel;
        //SearchBar searchBar;

        public HomeScreen()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var CurrentYear = DateTime.Today.Year;
            string year = CurrentYear.ToString();
            lblFecha.Text = "ICAP © Copyright " + year + " Todos los derechos reservados";
        }

        //VirtualCampus
        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VirtualCampusHome());
        }

        //ABOUT
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUsH());
        }

        //EVENTS
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventsLanding());
        }

        //MAPS
        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new MapPopUp());
        }

        //BLOG
        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Blog());
        }

        //HElP
        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Help());
        }
    }
}