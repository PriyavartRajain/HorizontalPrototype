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
    /// Interaction logic for ImmServicesWindow_5.xaml
    /// </summary>
    public partial class ImmServicesWindow_5 : Window
    {
        public ImmServicesWindow_5()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void showTextbox(object sender, RoutedEventArgs e)
        {
            registryinfo.Visibility = Visibility.Visible;
            get_directions_btn.Visibility = Visibility.Visible;
        }
        private void openImmServWindow4(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow_4 immServicesWindow4 = new ImmServicesWindow_4();
            this.Visibility = Visibility.Hidden;
            immServicesWindow4.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            explore.Visibility = Visibility.Hidden;
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {

        }

        private void openWindow3(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow_3 immServicesWindow_3 = new ImmServicesWindow_3();
            this.Visibility = Visibility.Hidden;
            immServicesWindow_3.Show();
        }
    }
}
