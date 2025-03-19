using F1Dashboard.Views;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace F1Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Content = new EventSchedule(); // Default page
        }

        private void NavigateToPage(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Content.ToString())
                {
                    case "Event Schedule":
                        ContentFrame.Content = new EventSchedule();
                        break;
                    case "Race Results":
                        ContentFrame.Content = new RaceResults();
                        break;
                   /* case "Timing Data":
                        ContentFrame.Content = new TimingData();
                        break;
                    case "Track Status":
                        ContentFrame.Content = new TrackStatus();
                        break;
                    case "Session Status":
                        ContentFrame.Content = new SessionStatus();
                        break;
                    case "Race Control Messages":
                        ContentFrame.Content = new RaceControl();
                        break;
                    case "Telemetry":
                        ContentFrame.Content = new Telemetry();
                        break;
                    case "Track Markers":
                        ContentFrame.Content = new TrackMarkers();
                        break;*/
                }
            }
        }
    }
}
