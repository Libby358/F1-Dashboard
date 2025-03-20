using System;
using System.Windows.Input;
using F1_Dashboard.Views;

namespace F1_Dashboard.ViewModels
{
    public class MainWindowViewModel
    {
        public ICommand NavigateCommand { get; private set; }
        public object CurrentPage { get; set; }

        public MainWindowViewModel()
        {
            NavigateCommand = new RelayCommand(NavigateToPage);
        }

        private void NavigateToPage(object parameter)
        {
            string pageName = parameter as string;
            switch (pageName)
            {
                case "EventSchedule":
                    CurrentPage = new EventSchedule();
                    break;
                case "RaceResults":
                    CurrentPage = new RaceResults();
                    break;
                default:
                    break;
            }
        }
    }
}
