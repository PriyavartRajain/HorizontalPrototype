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
    /// Interaction logic for MapPageWindow.xaml
    /// </summary>
    public partial class MapPageWindow : Window
    {
        public MapPageWindow()
        {
            InitializeComponent();
        }

        private void ExploreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            explore.Visibility = Visibility.Hidden;
            holidayInnImg.Visibility = Visibility.Visible;
            holidayInnLbl.Visibility = Visibility.Visible;
            hotel2img.Visibility = Visibility.Visible;
            hotel2lbl.Visibility = Visibility.Visible;
            hotel3img.Visibility = Visibility.Visible;
            hotel3lbl.Visibility = Visibility.Visible;
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {   
            search.Visibility = Visibility.Hidden;
            holidayInnImg.Visibility = Visibility.Visible;
            holidayInnLbl.Visibility = Visibility.Visible;
            hotel2img.Visibility = Visibility.Hidden;
            hotel2lbl.Visibility = Visibility.Hidden;
            hotel3img.Visibility = Visibility.Hidden;
            hotel3lbl.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MapZoomedOut mapZoomedOut = new MapZoomedOut();
            this.Visibility = Visibility.Hidden;
            mapZoomedOut.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MapZoomedIn mapZoomedIn = new MapZoomedIn();
            this.Visibility = Visibility.Hidden;
            mapZoomedIn.Show();
        }
    }
}
