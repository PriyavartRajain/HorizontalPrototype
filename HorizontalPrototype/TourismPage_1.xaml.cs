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
    /// Interaction logic for TourismPage_1.xaml
    /// </summary>
    public partial class TourismPage_1 : Window
    {
        public TourismPage_1()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void openTourismPage_2(object sender, MouseButtonEventArgs e)
        {
            TourismPage_2 tourismPage_2 = new TourismPage_2();
            this.Visibility = Visibility.Hidden;
            tourismPage_2.Show();
        }
    }
}
