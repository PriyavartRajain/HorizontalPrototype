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
    /// Interaction logic for housing2.xaml
    /// </summary>
    public partial class housing2 : Window
    {
        public housing2()
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
            Housing openHousing = new Housing();
            this.Visibility = Visibility.Hidden;
            openHousing.Show();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            search.Visibility = Visibility.Hidden;
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
