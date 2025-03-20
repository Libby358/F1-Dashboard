using System.Collections.ObjectModel;
using F1_Dashboard.Models;
using F1_Dashboard.Services;
using System.Threading.Tasks;

namespace F1_Dashboard.ViewModels
{
    public class TelemetryViewModel : ViewModelBase
    {
        private TelemetryData _telemetryData;
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

        public TelemetryData TelemetryData
        {
            get => _telemetryData;
            set
            {
                _telemetryData = value;
                OnPropertyChanged();
            }
        }

        // Method to load telemetry data (using placeholder data if usePlaceholder is true)
        public async Task LoadTelemetryData()
        {
            var telemetry = await ApiService.GetTelemetryData(Year, Round);
            TelemetryData = telemetry;
        }

        // Parameterless constructor
        public TelemetryViewModel()
        {
            // Default values for Year and Round
            Year = 2024;
            Round = 1;
            // Load telemetry data when the view model is initialized
            LoadTelemetryData();
        }

        // Constructor with parameters if needed later
        public TelemetryViewModel(int year, int round)
        {
            Year = year;
            Round = round;
            LoadTelemetryData();
        }
    }
}
