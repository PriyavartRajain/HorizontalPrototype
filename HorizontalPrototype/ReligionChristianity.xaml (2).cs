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
    /// Interaction logic for ReligionChristianity.xaml
    /// </summary>
    public partial class ReligionChristianity : Window
    {
        public ReligionChristianity()
        {
            InitializeComponent();
        }

        private void openReligion(object sender, RoutedEventArgs e)
        {
            Religion religion = new Religion();
            this.Visibility = Visibility.Hidden;
            religion.Show();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReligionChristianity mapZoomedOut = new ReligionChristianity();
            this.Visibility = Visibility.Hidden;
            mapZoomedOut.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ReligionChristianityzoomin mapZoomedIn = new ReligionChristianityzoomin();
            this.Visibility = Visibility.Hidden;
            mapZoomedIn.Show();
        }



        private void showhouse(object sender, RoutedEventArgs e)
        {
            ReligionChristianity2 window2 = new ReligionChristianity2();
            this.Visibility = Visibility.Hidden;
            window2.Show();
        }
    }
}
