using ICAP_API.Models;
using Innova_ICAP_V2.Controller;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Innova_ICAP_V2.ViewModels
{
    class EventsLandingViewModel : BaseViewModel
    {
        private EventsController eventsControllerObject;

        public ObservableCollection<EventsModel> Items { get; set; }

        public Command LoadItemsCommand { get; set; }

        public EventsLandingViewModel()
        {
            eventsControllerObject = new EventsController();
            Title = "events";
            Items = new ObservableCollection<EventsModel>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public void EventsLandingFilterByDate()
        {

        }


        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var lista = await eventsControllerObject.GetEventsList();

                foreach (EventsModel e in lista)
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
