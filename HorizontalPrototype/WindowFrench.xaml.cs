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
    /// Interaction logic for WindowFrench.xaml
    /// </summary>
    public partial class WindowFrench : Window
    {
        public WindowFrench()
        {
            InitializeComponent();
        }
        private void openMapPage(object sender, RoutedEventArgs e)
        {
            MapPageWindow mapPage = new MapPageWindow();
            this.Visibility = Visibility.Hidden;
            mapPage.Show();
        }

        private void openImmServices(object sender, RoutedEventArgs e)
        {
            ImmServicesWindow immServ = new ImmServicesWindow();
            this.Visibility = Visibility.Hidden;
            immServ.Show();
        }

        private void callButton_Click(object sender, RoutedEventArgs e)
        {
            Call call = new Call();
            this.Visibility = Visibility.Hidden;
            call.Show();
        }

        private void openMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void openReligion(object sender, RoutedEventArgs e)
        {
            Religion religion = new Religion();
            this.Visibility = Visibility.Hidden;
            religion.Show();
        }

        private void openTourism1(object sender, RoutedEventArgs e)
        {
            TourismPage_1 tourism1 = new TourismPage_1();
            this.Visibility = Visibility.Hidden;
            tourism1.Show();
        }

        private void openTransit(object sender, RoutedEventArgs e)
        {
            Transit transit = new Transit();
            this.Visibility = Visibility.Hidden;
            transit.Show();
        }

        private void openByLaws(object sender, RoutedEventArgs e)
        {
            ByLaws byLaws = new ByLaws();
            this.Visibility = Visibility.Hidden;
            byLaws.Show();
        }

        private void housingButton_Click(object sender, RoutedEventArgs e)
        {
            Housing housing = new Housing();
            this.Visibility = Visibility.Hidden;
            housing.Show();
        }

        private void eventsButton_Click(object sender, RoutedEventArgs e)
        {
            Events events = new Events();
            this.Visibility = Visibility.Hidden;
            events.Show();
        }
    }
}
