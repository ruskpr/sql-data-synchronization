using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace SyncApp_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // show home page content on start up
            GoToHomePage();
        }

        private void TreeViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (TreeViewItem)sender;
            string tag = item.Tag.ToString();

            mainContentFrame.NavigationService.Navigate(new Uri($"Pages/{tag}.xaml", UriKind.Relative));
        }



        // NAVIGATION
        private void btnNext(object sender, RoutedEventArgs e)
        {
            if (mainContentFrame.NavigationService.CanGoForward)
                mainContentFrame.NavigationService.GoForward();
            else
                GoToHomePage();
        }

        private void btnPrevious(object sender, RoutedEventArgs e)
        {
            if (mainContentFrame.NavigationService.CanGoBack)
                mainContentFrame.NavigationService.GoBack();
            else
                GoToHomePage();
        }

        void GoToHomePage() => mainContentFrame.NavigationService.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
    }
}
