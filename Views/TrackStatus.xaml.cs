using System.Windows.Controls;
using F1_Dashboard.ViewModels;

namespace F1_Dashboard.Views
{
    public partial class TrackStatus : UserControl
    {
        public TrackStatus()
        {
            InitializeComponent();

            // Access the DataContext and set Year and Round properties
            var viewModel = DataContext as TrackStatusViewModel;
            if (viewModel != null)
            {
                viewModel.LoadTrackStatus(2024, 1); // Example: Load track status for Year 2024 and Round 1
            }
        }
    }
}


