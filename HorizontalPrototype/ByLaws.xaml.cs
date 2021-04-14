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
    /// Interaction logic for ByLaws.xaml
    /// </summary>
    public partial class ByLaws : Window
    {
        public ByLaws()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void Littering_Click(object sender, RoutedEventArgs e)
        {
            Littering littering = new Littering();
            this.Visibility = Visibility.Hidden;
            littering.Show();
        }
    }
}
