using System;
using System.Windows.Controls;
using F1_Dashboard.ViewModels;

namespace F1_Dashboard.Views
{
    public partial class Telemetry : UserControl
    {
        public Telemetry()
        {
            InitializeComponent();

            // Access the DataContext and set Year and Round properties
            var viewModel = DataContext as TelemetryViewModel;
            if (viewModel != null)
            {
                viewModel.Year = 2024; // Example Year
                viewModel.Round = 1;   // Example Round
                viewModel.LoadTelemetryData(); // Load the telemetry data
            }
        }
    }
}

