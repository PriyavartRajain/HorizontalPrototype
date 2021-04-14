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
    /// Interaction logic for TransitTrain.xaml
    /// </summary>
    public partial class TransitTrain : Window
    {
        public TransitTrain()
        {
            InitializeComponent();
        }

        private void Transit(object sender, RoutedEventArgs e)
        {
            Transit window1 = new Transit();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransitBus tbus = new TransitBus();
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
