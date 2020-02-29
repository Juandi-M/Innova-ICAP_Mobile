using ICAP_API.Models;
using Innova_ICAP_V2.Controller;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Innova_ICAP_V2.ViewModels
{
    class ActivitiesViewModel : BaseViewModel
    {
        private ActivitiesController eventsControllerObject;

        public ObservableCollection<ActivitiesModel> Items { get; set; }

        public Command LoadItemsCommand { get; set; }

        public ActivitiesViewModel()
        {
            eventsControllerObject = new ActivitiesController();
            Title = "events";
            Items = new ObservableCollection<ActivitiesModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var lista = await eventsControllerObject.GetActivitiesList();

                foreach (ActivitiesModel e in lista)
                {
                    Items.Add(e);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
