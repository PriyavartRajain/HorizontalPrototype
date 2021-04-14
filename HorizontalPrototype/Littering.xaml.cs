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
    /// Interaction logic for Littering.xaml
    /// </summary>
    public partial class Littering : Window
    {
        public Littering()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void openByLaws(object sender, RoutedEventArgs e)
        {
            ByLaws byLaws = new ByLaws();
            this.Visibility = Visibility.Hidden;
            byLaws.Show();
        }
    }
}
