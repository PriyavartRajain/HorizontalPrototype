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
    /// Interaction logic for LoginScreen_2.xaml
    /// </summary>
    public partial class LoginScreen_2 : Window
    {
        public LoginScreen_2()
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

        private void Sign_upButton_Click(object sender, RoutedEventArgs e)
        {
            Signup signup = new Signup();
            this.Visibility = Visibility.Hidden;
            signup.Show();
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


    }
}
