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
    /// Interaction logic for TourismPage_2.xaml
    /// </summary>
    public partial class TourismPage_2 : Window
    {
        public TourismPage_2()
        {
            InitializeComponent();
        }

        private void openTourism1(object sender, RoutedEventArgs e)
        {
            TourismPage_1 tourism1 = new TourismPage_1();
            this.Visibility = Visibility.Hidden;
            tourism1.Show();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
    }
}
