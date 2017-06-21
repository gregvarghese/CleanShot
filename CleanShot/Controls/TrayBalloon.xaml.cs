﻿using CleanShot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CleanShot.Controls
{
    /// <summary>
    /// Interaction logic for TrayBalloon.xaml
    /// </summary>
    public partial class TrayBalloon : UserControl
    {
        public TrayBalloon()
        {
            InitializeComponent();
        }

        private void UserControl_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Settings.Current.IsTrayNotificationEnabled = false;
            (this.Parent as Popup).IsOpen = false;

        }
    }
}
