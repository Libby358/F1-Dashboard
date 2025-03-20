using System.Collections.ObjectModel;
using F1_Dashboard.Models;
using F1_Dashboard.Services;
using System.Threading.Tasks;

namespace F1_Dashboard.ViewModels
{
    public class TrackMarkersViewModel : ViewModelBase
    {
        private ObservableCollection<TrackMarkers> _trackMarkers;
        private int _year;
        private int _round;

        public int Year
        {
            get => _year;
            set
            {
                _year = value;
                OnPropertyChanged();
            }
        }

        public int Round
        {
            get => _round;
            set
            {
                _round = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TrackMarkers> TrackMarkers
        {
            get => _trackMarkers;
            set
            {
                _trackMarkers = value;
                OnPropertyChanged();
            }
        }

        // Method to load track markers (using API or placeholder data)
        public async Task LoadTrackMarkers()
        {
            var trackMarkers = await ApiService.GetTrackMarkers(Year, Round);
            TrackMarkers = new ObservableCollection<TrackMarkers>(trackMarkers);
        }

        // Parameterless constructor
        public TrackMarkersViewModel()
        {
            // Default values for Year and Round
            Year = 2024;
            Round = 1;
            // Load track markers when the view model is initialized
            LoadTrackMarkers();
        }

        // Constructor with parameters for future use
        public TrackMarkersViewModel(int year, int round)
        {
            Year = year;
            Round = round;
            LoadTrackMarkers();
        }
    }
}

