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
    /// Interaction logic for ImmServicesWindow_3.xaml
    /// </summary>
    public partial class ImmServicesWindow_3 : Window
    {
        public ImmServicesWindow_3()
        {
            InitializeComponent();
        }

        private void openImmServWindow2(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow_2 immServicesWindow2 = new ImmServicesWindow_2();
            this.Visibility = Visibility.Hidden;
            immServicesWindow2.Show();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
    }
}
