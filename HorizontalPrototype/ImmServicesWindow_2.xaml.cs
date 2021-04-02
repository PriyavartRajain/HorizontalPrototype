using System;
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
    /// Interaction logic for ImmServicesWindow_2.xaml
    /// </summary>
    public partial class ImmServicesWindow_2 : Window
    {
        public ImmServicesWindow_2()
        {
            InitializeComponent();
        }


        private void openImmServWindow1(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow immServicesWindow = new ImmServicesWindow();
            this.Visibility = Visibility.Hidden;
            immServicesWindow.Show();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void openImmServWindow3(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow_3 immServicesWindow3 = new ImmServicesWindow_3();
            this.Visibility = Visibility.Hidden;
            immServicesWindow3.Show();
        }

        private void openWindow1(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
    }
}
