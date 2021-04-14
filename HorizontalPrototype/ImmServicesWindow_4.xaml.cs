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
    /// Interaction logic for ImmServicesWindow_4.xaml
    /// </summary>
    public partial class ImmServicesWindow_4 : Window
    {
        public ImmServicesWindow_4()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            explore.Visibility = Visibility.Hidden;
        }


        private void openWindow5(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow_5 immServicesWindow_5 = new ImmServicesWindow_5();
            this.Visibility = Visibility.Hidden;
            immServicesWindow_5.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
