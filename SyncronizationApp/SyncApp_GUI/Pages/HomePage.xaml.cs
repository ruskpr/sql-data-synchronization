﻿using System;
using System.Collections.Generic;
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
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            // check if bg process is running
            bool processIsRunning = Lib.Core.BgProcess.IsRunning();

            // update ui accordingly
            //processIsRunning
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
