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
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void openHome(object sender, RoutedEventArgs e)
        {
            Window openHome = new Window1();
            this.Visibility = Visibility.Hidden;
            openHome.Show();
        }

        private void OpenSignUp(object sender, RoutedEventArgs e)
        {
            LoginScreen_2 openSignUp = new LoginScreen_2();
            this.Visibility = Visibility.Hidden;
            openSignUp.Show();
        }


        private void openLogin(object sender, RoutedEventArgs e)
        {
            LoginScreen_3 openLogin = new LoginScreen_3();
            this.Visibility = Visibility.Hidden;
            openLogin.Show();
        }

        private void openMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
