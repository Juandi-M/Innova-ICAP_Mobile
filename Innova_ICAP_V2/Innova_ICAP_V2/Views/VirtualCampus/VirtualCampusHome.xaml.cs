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
    public partial class VirtualCampusHome : ContentPage
    {
        public VirtualCampusHome()
        {
            InitializeComponent();
        }

   
        //Moodle
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoodleLogin());
        }

        //Library
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VritualLibrary());
        }


        //Akamsys
        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AcamsysLogIn());
        }

        //Requests
        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Requests());
        }

        //TechSupport
        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TechSupport());
        }

    }
}