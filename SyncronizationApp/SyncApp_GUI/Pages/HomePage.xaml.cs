using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Windows.Devices.Display.Core;

namespace SyncApp_GUI.Pages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            DisplayDbConfiguration();
        }

        private void DisplayDbConfiguration()
        {
            string sqlConnString = ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
            string sqliteConnString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
            string server = sqlConnString.Split(';')[0];
            string database = sqlConnString.Split(';')[1];
            string localDb = sqliteConnString.Split("=")[1];

            lbServer.Content = server;
            lbDatabase.Content = database;
            lbOfflineDB.Content = "Offline data store: " + localDb;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            // check if bg process is running
            bool processIsRunning = Lib.Core.BgProcess.IsRunning();

            // update ui accordingly
            string status = processIsRunning ? "Running" : "Not running";
            lbStatus.Text = $"Status: {status}";
        }

        #region start / stop bg process button clicks

        private void btnStartBgService_Click(object sender, RoutedEventArgs e)
        {
            Lib.Core.BgProcess.StartProcessWithMaxOneInstance();
        }

        private void btnKillBgService_Click(object sender, RoutedEventArgs e)
        {
            Lib.Core.BgProcess.KillAllInstances();
        }

        #endregion
    }
}
