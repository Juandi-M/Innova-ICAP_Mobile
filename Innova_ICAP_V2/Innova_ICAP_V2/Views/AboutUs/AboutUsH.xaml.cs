using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Innova_ICAP_V2.Views.AboutUs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUsH : Xamarin.Forms.TabbedPage
    {

        public AboutUsH()
        {
            //codigo depricated pero funciona, por ende el wanring
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom)
            .SetBarItemColor(Color.Navy)
             .SetBarSelectedItemColor(Color.Orange);

        }

        private async void TapGestureRecognizer_Tapped_Faceb(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("fb://page/124702921022196"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("No Instaldo", "Por favor installar la aplicacion antes de poder usar.", "Ok");
            }
        }

        private async void TapGestureRecognizer_Tapped_Tweet(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("twitter://user?user_id=770631079141183488"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("No Instaldo", "Por favor installar la aplicacion antes de poder usar.", "Ok");
            }
        }

        private async void TapGestureRecognizer_Tapped_Insta(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("instagram://user?username=icap_1954"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("No Instaldo", "Por favor installar la aplicacion antes de poder usar.", "Ok");
            }
        }

        private async void TapGestureRecognizer_Tapped_Phone1(object sender, EventArgs e)
        {

            var CallUsLabel = new Label { Text = "+506 2234-1011" };
            try
            {
                CallUsLabel.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(() =>
                    {
                        Device.OpenUri(new Uri("tel:+50622341011"));
                    })
                });
            }
            catch (ArgumentNullException anEx)
            {
                await DisplayAlert("Error", "Teléfono no responde", "Ok");
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Error", "No soportado para este modelo", "Ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Ocurrio un error", "Ok");

            }

        }

        private async void TapGestureRecognizer_Tapped_Phone2(object sender, EventArgs e)
        {
            var CallUsLabel2 = new Label { Text = "+506 2225-4616" };
            CallUsLabel2.Text = "+506 2225-4616";

            try
            {
                CallUsLabel2.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(() =>
                    {
                        Device.OpenUri(new Uri("tel:+50622254616"));
                    })
                });
            }
            catch
            {
                await DisplayAlert("Error", "Teléfono no responde", "Ok");
            }


        }
    }
}