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
    /// Interaction logic for Housingzoomin.xaml
    /// </summary>
    public partial class Housingzoomin : Window
    {
        public Housingzoomin()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }



        private void goback(object sender, RoutedEventArgs e)
        {
            EventsFestivals openfestival = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Housing mapZoomedOut = new Housing();
            this.Visibility = Visibility.Hidden;
            mapZoomedOut.Show();
        }

        private void showhouse(object sender, RoutedEventArgs e)
        {
            housing2 window2 = new housing2();
            this.Visibility = Visibility.Hidden;
            window2.Show();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            search.Visibility = Visibility.Hidden;


        }
    }
}
