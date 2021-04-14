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
    /// Interaction logic for CallPersonal.xaml
    /// </summary>
    public partial class CallPersonal : Window
    {
        public CallPersonal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CallCash callCash = new CallCash();
            this.Visibility = Visibility.Hidden;
            callCash.Show();
        }

        private void openCall(object sender, RoutedEventArgs e)
        {
            Call call = new Call();
            this.Visibility = Visibility.Hidden;
            call.Show();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
    }
}
