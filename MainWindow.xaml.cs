using F1_Dashboard.ViewModels;
using System;
using System.Windows;

namespace F1_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                Console.WriteLine("MainWindow constructor called.");
                InitializeComponent();

                // Set the ViewModel as the DataContext
                this.DataContext = new MainWindowViewModel(); // Set the view model for data binding
                Console.WriteLine("DataContext set to MainWindowViewModel.");

                // Default page is already set in ViewModel, no need to set ContentFrame here
                Console.WriteLine("ViewModel is set, content will be bound via MVVM.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in MainWindow constructor: {ex.Message}");
            }
        }
    }
}
