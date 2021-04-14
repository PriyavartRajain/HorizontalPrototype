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
    /// Interaction logic for CallDuration.xaml
    /// </summary>
    public partial class CallDuration : Window
    {
        public CallDuration()
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
            CallComplete callComplete = new CallComplete();
            this.Visibility = Visibility.Hidden;
            callComplete.Show();
        }
    }
}
