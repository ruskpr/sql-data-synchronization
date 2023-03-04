using Lib.Core.EF.DbContexts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
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

namespace SyncApp_GUI.Pages
{
    /// <summary>
    /// Interaction logic for GenerateData.xaml
    /// </summary>
    public partial class GenerateData : Page
    {
        SqliteContext sqlite = new SqliteContext();
        public GenerateData()
        {
            InitializeComponent();
            UpdateData();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 10);
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Task.Run(() => UpdateData());
        }

        private void UpdateData()
        {
            var offlineData = sqlite.DataEntries.ToList();
            dgData.ItemsSource = offlineData;
            lbRecordsToSync.Content = "Records to sync: " + offlineData.Count;
            lbDataStorePath.Content = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
            dgData.ItemsSource = sqlite.DataEntries.ToList();
        }

        private async void btnGenerateData_Click(object sender, RoutedEventArgs e)
        {
            Lib.Core.Generation.DataGenerator generator = new Lib.Core.Generation.DataGenerator();


            int numRecords = 0;
            bool isValidNumber = int.TryParse(tbNumRecords.Text, out numRecords);
            if (isValidNumber && numRecords > 0 && numRecords < 5001)
            {
                lbErrorMsg.Text = "";
                btnGenerate.Content = $"Generating {numRecords} records...";
                generator.GenerateData(numRecords);

            }
            else
            {
                lbErrorMsg.Text = "Invalid number, enter a value up to 5000";
                tbNumRecords.Text = "";
                return;
            }

            btnGenerate.Content = $"Generate random records";
            UpdateData();
        }
    }
}
