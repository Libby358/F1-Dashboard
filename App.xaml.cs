using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace F1_Dashboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            App app = new App();
            MainWindow mainWindow = new MainWindow();
            app.Run(mainWindow); // Ensure the MainWindow is opened
        }
    }

}
