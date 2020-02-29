using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;


namespace Innova_ICAP_V2.Views.AboutUs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPopUp
    {
        public MapPopUp()
        {
            InitializeComponent();
        }

        //Funcion para Dirreciones con mapa

        private void Button_Clicked_Dir1(object sender, System.EventArgs e)
        {
            var location = new Location(9.926369, -84.041771);// ICAP Sede Central
            var options = new MapLaunchOptions { Name = "ICAP Sede Central" };
            //await revisar el uso de threading el codigo below
            Map.OpenAsync(location, options);
            PopupNavigation.Instance.PopAsync();
        }

        private void Button_Clicked_Dir2(object sender, System.EventArgs e)
        {
            var location2 = new Location(9.926061, -84.040752); // ICAP Centro de posgrados
            var options = new MapLaunchOptions { Name = "ICAP Centro de Posgrados" };
            //await revisar el uso de threading el codigo below
            Map.OpenAsync(location2, options);
            PopupNavigation.Instance.PopAsync();
        }

        private void Button_Clicked_Dir3(object sender, System.EventArgs e)
        {
            var location2 = new Location(8.9971702, -79.5810441); // ICAP Panama
            var options = new MapLaunchOptions { Name = "ICAP Sede Panama" };
            //await revisar el uso de threading el codigo below
            Map.OpenAsync(location2, options);
            PopupNavigation.Instance.PopAsync();
        }

    }
}