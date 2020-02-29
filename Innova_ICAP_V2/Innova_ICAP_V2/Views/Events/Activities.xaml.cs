using ICAP_API.Models;
using Innova_ICAP_V2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Innova_ICAP_V2.Views.Events
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activities : ContentPage
    {
        private ActivitiesViewModel viewModel;
        public Activities()
        {
            InitializeComponent();
            //BindingContext = viewModel = new ActivitiesViewModel();
        }
        //    //Aqui se maneja movimiento de una pantalla a otra.
        //    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //    {
        //        var item = args.SelectedItem as ActivitiesModel;
        //        if (item == null)
        //            return;

        //        //var nav = (EventsModel)item;
        //        //var id = Convert.ToInt32(nav.Codigo_Articulo);
        //        //IdArt = id;
        //        //// Manually deselect item
        //        //

        //        //EventsListView.SelectedItem = null;

        //        //App.Current.MainPage = new NavigationPage(new Events2());
        //    }
        //    protected override void OnAppearing()
        //    {
        //        base.OnAppearing();
        //        if (viewModel.Items.Count == 0)
        //            viewModel.LoadItemsCommand.Execute(null);
        //    }
    }
}
