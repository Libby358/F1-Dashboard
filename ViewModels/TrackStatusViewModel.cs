using System.Collections.ObjectModel;
using System.ComponentModel;

namespace F1_Dashboard.ViewModels
{
    public class TrackStatusViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TrackStatus> _trackStatusList;

        public ObservableCollection<TrackStatus> TrackStatusList
        {
            get { return _trackStatusList; }
            set
            {
                _trackStatusList = value;
                OnPropertyChanged(nameof(TrackStatusList));
            }
        }

        // Define LoadTrackStatus method
        public void LoadTrackStatus(int year, int round)
        {
            // Simulate loading data for a specific year and round
            // You can replace this with actual data loading logic (e.g., from a database, API, etc.)
            TrackStatusList = new ObservableCollection<TrackStatus>
            {
                new TrackStatus { TrackCondition = "Dry", Temperature = "30°C", WindSpeed = "5 km/h", SafetyCarStatus = "Inactive", LapTimeDelays = "None", FlagStatus = "Green", IncidentReports = "None" },
                new TrackStatus { TrackCondition = "Wet", Temperature = "22°C", WindSpeed = "10 km/h", SafetyCarStatus = "Active", LapTimeDelays = "5 seconds", FlagStatus = "Yellow", IncidentReports = "Crash" }
            };
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // Assuming TrackStatus class is defined like this
    public class TrackStatus
    {
        public string TrackCondition { get; set; }
        public string Temperature { get; set; }
        public string WindSpeed { get; set; }
        public string SafetyCarStatus { get; set; }
        public string LapTimeDelays { get; set; }
        public string FlagStatus { get; set; }
        public string IncidentReports { get; set; }
    }
}
