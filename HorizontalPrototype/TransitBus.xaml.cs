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
    /// Interaction logic for TransitBus.xaml
    /// </summary>
    public partial class TransitBus : Window
    {
        public TransitBus()
        {
            InitializeComponent();
        }

        private void TrainMain(object sender, RoutedEventArgs e)
        {
            Transit window1 = new Transit();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void ShowDirection(object sender, RoutedEventArgs e)
        {
            get_directions_btn.Visibility = Visibility.Visible;
        }

        private void get_directions_btn_Click(object sender, RoutedEventArgs e)
        {
            TransitBusFinal window1 = new TransitBusFinal();
            this.Visibility = Visibility.Hidden;
            window1.Show();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransitTrain tbus = new TransitTrain();
            this.Visibility = Visibility.Hidden;
            tbus.Show();
        }
    }
}
