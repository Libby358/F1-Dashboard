using F1_Dashboard.Models;
using F1_Dashboard.Views;
using System.ComponentModel;
using System.Windows.Controls;

namespace F1_Dashboard.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private UserControl _currentPage;
        public UserControl CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public RelayCommand NavigateCommand { get; }

        public MainWindowViewModel()
        {
            // Set default page when the app starts
            CurrentPage = new EventSchedule();

            // Initialize navigation command
            NavigateCommand = new RelayCommand(NavigateToPage);
        }

        private void NavigateToPage(object parameter)
        {
            if (parameter is string pageName)
            {
                switch (pageName)
                {
                    case "EventSchedule":
                        CurrentPage = new EventSchedule();
                        break;
                    case "RaceResults":
                        CurrentPage = new RaceResults();
                        break;
                    case "TrackStatus":
                        CurrentPage = new Views.TrackStatus();
                        break;
                    case "SessionStatus":
                        CurrentPage = new Views.SessionStatus();
                        break;
                    case "RaceControlMessages":
                        CurrentPage = new RaceControlMessages();
                        break;
                    case "Telemetry":
                        CurrentPage = new Telemetry();
                        break;
                    case "TrackMarkers":
                        CurrentPage = new Views.TrackMarkers();
                        break;
                    default:
                        CurrentPage = new EventSchedule();
                        break;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}




