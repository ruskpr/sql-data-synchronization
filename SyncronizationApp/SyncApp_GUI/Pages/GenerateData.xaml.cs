using Lib.Core.EF.DbContexts;
using System;
using System.Collections.Generic;
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
                await Task.Run(() => generator.GenerateData(numRecords));

            }
            else
            {
                lbErrorMsg.Text = "Invalid number, enter a value up to 5000";
                tbNumRecords.Text = "";
                return;
            }

            btnGenerate.Content = $"Generate random records";
            dgData.ItemsSource = sqlite.DataEntries.ToList();
        }
    }
}
