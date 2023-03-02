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
        public GenerateData()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lib.Core.Generation.DataGenerator generator = new Lib.Core.Generation.DataGenerator();
            generator.GenerateData();
        }
    }
}
