using F1_Dashboard.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace F1_Dashboard.Views
{
    public partial class EventSchedule : UserControl
    {
        public EventSchedule()
        {
            InitializeComponent(); // Initializes the page components
            DataContext = new EventScheduleViewModel(); // Bind the view model to the page
        }
    }
}


