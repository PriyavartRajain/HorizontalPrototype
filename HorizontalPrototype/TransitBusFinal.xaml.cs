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
    /// Interaction logic for TransitBusFinal.xaml
    /// </summary>
    public partial class TransitBusFinal : Window
    {
        public TransitBusFinal()
        {
            InitializeComponent();
        }

        private void TransitBus(object sender, RoutedEventArgs e)
        {
            TransitBus tbus = new TransitBus();
            tbus.get_directions_btn.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Hidden;
            tbus.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransitTrain tbus = new TransitTrain();
            this.Visibility = Visibility.Hidden;
            tbus.Show();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "Search...")
            {
                Username.Clear();
            }
        }

        private void Username_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "" | Username.Text == null)
            {
                Username.Text = "Search...";
            }
        }
    }
}
