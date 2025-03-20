using System.Collections.ObjectModel;
using System.Threading.Tasks;
using F1_Dashboard.Models;
using F1_Dashboard.Services;

namespace F1_Dashboard.ViewModels
{
    public class EventScheduleViewModel : ViewModelBase
    {
        private ObservableCollection<Event> _events;
        public ObservableCollection<Event> Events
        {
            get { return _events; }
            set { _events = value; OnPropertyChanged(nameof(Events)); }
        }

        public EventScheduleViewModel()
        {
            LoadEvents();
        }

        private async void LoadEvents()
        {
            var eventList = await ApiService.GetEventSchedule();
            Events = new ObservableCollection<Event>(eventList);
        }
    }
}
