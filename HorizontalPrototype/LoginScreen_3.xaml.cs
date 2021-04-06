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
    /// Interaction logic for LoginScreen_3.xaml
    /// </summary>
    public partial class LoginScreen_3 : Window
    {
        public LoginScreen_3()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void openLoginScreen(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }

        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "Enter username here")
            {
                Username.Clear();
            }
        }

        private void Username_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "" | Username.Text == null)
            {
                Username.Text = "Enter username here";
            }
        }


        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Password.Opacity = 0;
            PasswordBox.Opacity = 100;

        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "")
            {
                Password.Opacity = 100;
                PasswordBox.Opacity = 0;
            }
        }

        private void Sign_upButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
    }
}
