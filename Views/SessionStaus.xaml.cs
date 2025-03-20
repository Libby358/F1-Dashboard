using F1_Dashboard.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace F1_Dashboard.Views
{
    public partial class SessionStatus : UserControl
    {
        public SessionStatus()
        {
            InitializeComponent(); // Initializes the page components
            DataContext = new SessionStatusViewModel(); // Bind the view model to the page
        }
    }
}


