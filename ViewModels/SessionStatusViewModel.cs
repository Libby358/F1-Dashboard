using System.Collections.ObjectModel;
using F1_Dashboard.Models;
using F1_Dashboard.Services;
using System.Threading.Tasks;

namespace F1_Dashboard.ViewModels
{
    public class SessionStatusViewModel : ViewModelBase
    {
        private ObservableCollection<SessionStatus> _sessionStatuses;

        public ObservableCollection<SessionStatus> SessionStatuses
        {
            get => _sessionStatuses;
            set
            {
                _sessionStatuses = value;
                OnPropertyChanged();
            }
        }

        // Method to load session statuses (using placeholder data if usePlaceholder is true)
        public async Task LoadSessionStatuses()
        {
            // Use the ApiService to fetch the session statuses or use the placeholder
            var statuses = await ApiService.GetSessionStatuses();
            SessionStatuses = new ObservableCollection<SessionStatus>(statuses);
        }

        public SessionStatusViewModel()
        {
            // Load the session statuses when the view model is initialized
            LoadSessionStatuses();
        }
    }
}
