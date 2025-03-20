using System.Collections.ObjectModel;
using F1_Dashboard.Models;
using F1_Dashboard.Services;
using System.Threading.Tasks;

namespace F1_Dashboard.ViewModels
{
    public class RaceControlMessagesViewModel : ViewModelBase
    {
        private ObservableCollection<RaceControlMessage> _raceControlMessages;

        public ObservableCollection<RaceControlMessage> RaceControlMessages
        {
            get => _raceControlMessages;
            set
            {
                _raceControlMessages = value;
                OnPropertyChanged();
            }
        }

        // Method to load race control messages (using placeholder data if usePlaceholder is true)
        public async Task LoadRaceControlMessages()
        {
            // Use the ApiService to fetch the race control messages or use the placeholder
            var messages = await ApiService.GetRaceControlMessages();
            RaceControlMessages = new ObservableCollection<RaceControlMessage>(messages);
        }

        public RaceControlMessagesViewModel()
        {
            // Load the race control messages when the view model is initialized
            LoadRaceControlMessages();
        }
    }
}
