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
    /// Interaction logic for CallDial.xaml
    /// </summary>
    public partial class CallDial : Window
    {

        long number = 0;
        public CallDial()
        {
            InitializeComponent();
        }

        private void openCollectChange(object sender, RoutedEventArgs e)
        {
            CollectChange collectChange = new CollectChange();
            this.Visibility = Visibility.Hidden;
            collectChange.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CallHandSet handSet = new CallHandSet();
            this.Visibility = Visibility.Hidden;
            handSet.Show();
        }

        private void Pad_1(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 1;
            display.Text = number.ToString();
        }

        private void Pad_2(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 2;
            display.Text = number.ToString();
        }

        private void Pad_3(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 3;
            display.Text = number.ToString();
        }

        private void Pad_4(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 4;
            display.Text = number.ToString();
        }

        private void Pad_5(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 5;
            display.Text = number.ToString();
        }

        private void Pad_6(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 6;
            display.Text = number.ToString();
        }

        private void Pad_7(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 7;
            display.Text = number.ToString();
        }

        private void Pad_8(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 8;
            display.Text = number.ToString();
        }

        private void Pad_9(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 9;
            display.Text = number.ToString();
        }

        private void Pad_0(object sender, RoutedEventArgs e)
        {
            number = (number * 10) + 0;
            display.Text = number.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            number = (number / 10);
            if(number == 0)
            {
                display.Text = "".ToString();
            }
            else
            {
                display.Text = number.ToString();
            }
        
        }
    }
}
