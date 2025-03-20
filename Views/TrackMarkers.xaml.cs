using System.Windows.Controls;
using F1_Dashboard.ViewModels;

namespace F1_Dashboard.Views
{
    public partial class TrackMarkers : UserControl
    {
        public TrackMarkers()
        {
            InitializeComponent();

            // Access the DataContext and set Year and Round properties
            var viewModel = DataContext as TrackMarkersViewModel;
            if (viewModel != null)
            {
                viewModel.Year = 2024; // Example Year
                viewModel.Round = 1;   // Example Round
                viewModel.LoadTrackMarkers(); // Load the track markers
            }
        }
    }
}

