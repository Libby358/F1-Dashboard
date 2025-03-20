using F1_Dashboard.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace F1_Dashboard.Views
{
    public partial class RaceControlMessages : UserControl
    {
        public RaceControlMessages()
        {
            InitializeComponent(); // Initializes the page components
            DataContext = new RaceControlMessagesViewModel(); // Bind the view model to the page
        }
    }
}


