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
    /// Interaction logic for ReligionChristianityzoomin.xaml
    /// </summary>
    public partial class ReligionChristianityzoomin : Window
    {
        public ReligionChristianityzoomin()
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
            ReligionChristianity openfestival = new ReligionChristianity();
            this.Visibility = Visibility.Hidden;
            openfestival.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReligionChristianity mapZoomedOut = new ReligionChristianity();
            this.Visibility = Visibility.Hidden;
            mapZoomedOut.Show();
        }
     
        private void showreligion(object sender, RoutedEventArgs e)
        {
            ReligionChristianity2 religion = new ReligionChristianity2();
            this.Visibility = Visibility.Hidden;
            religion.Show();
        }





    }
}
