using Lib.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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



        #region navigation

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

        private void GoToHomePage() => mainContentFrame.NavigationService.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));

        #endregion

        #region onClosing


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!BgProcess.IsRunning())
                return;

            var dialogResult = MessageBox.Show("Do you want the background service to continue running?",
                                         this.Title,
                                         MessageBoxButton.YesNoCancel);
            switch (dialogResult)
            {
                case MessageBoxResult.None: // cancel app closing
                    e.Cancel = true;
                    break;
                case MessageBoxResult.Cancel: // cancel app closing
                    e.Cancel = true;
                    break;
                case MessageBoxResult.Yes: // do nothing (bg service keeps running)
                    break;
                case MessageBoxResult.No: // stop bg service
                    BgProcess.KillAllInstances();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
