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
    /// Interaction logic for Events.xaml
    /// </summary>
    public partial class Events : Window
    {
        public Events()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }



        private void OnClick1(object sender, RoutedEventArgs e)
        {
            EventsFestivals openfestival = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }
        private void Click3(object sender, RoutedEventArgs e)
        {
            EventsFestivals openmusic = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openmusic.Show();
        }
        private void Click2(object sender, RoutedEventArgs e)
        {
            EventsFestivals openfestival = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }
        private void Click4(object sender, RoutedEventArgs e)
        {
            EventsFestivals openfestival = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }
        private void Click5(object sender, RoutedEventArgs e)
        {
            EventsFestivals openfestival = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }
        private void Click6(object sender, RoutedEventArgs e)
        {
            EventsFestivals openfestival = new EventsFestivals();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }

    }
}
