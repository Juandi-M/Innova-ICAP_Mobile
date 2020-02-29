using ICAP_API.Models;
using Innova_ICAP_V2.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Innova_ICAP_V2.Views.Events
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsLanding : TabbedPage
    {
        private EventsLandingViewModel viewModel;
        public EventsLanding()
        {
            InitializeComponent();

            var clr = Color.FromHex("#0C2340");
            this.BarBackgroundColor = clr;

            BindingContext = viewModel = new EventsLandingViewModel();
        }
        //Aqui se maneja movimiento de una pantalla a otra.
        void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as EventsModel;
            if (item == null)
                return;

            //Llamar actividad del evento
            var nav = item;
            var id = Convert.ToInt32(nav.Id);

            //Id = id;
            //// Manually deselect item
            EventsListView.SelectedItem = null;

            //App.Current.MainPage = new NavigationPage(new Events2());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
