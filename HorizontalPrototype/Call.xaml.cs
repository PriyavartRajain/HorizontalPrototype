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
    /// Interaction logic for Call.xaml
    /// </summary>
    public partial class Call : Window
    {
        public Call()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CallPersonal callPersonal = new CallPersonal();
            this.Visibility = Visibility.Hidden;
            callPersonal.Show();
        }

        private void Slider_ValueChanged()
        {

        }
    }
}
