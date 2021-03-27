﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HorizontalPrototype
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void openMapPage(object sender, RoutedEventArgs e)
        {
            MapPageWindow mapPage = new MapPageWindow();
            this.Visibility = Visibility.Hidden;
            mapPage.Show();
        }

        private void openImmServices(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow immServ = new ImmServicesWindow();
            this.Visibility = Visibility.Hidden;
            immServ.Show();
        }
    }
}
