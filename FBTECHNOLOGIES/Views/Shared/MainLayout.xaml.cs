using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FBTECHNOLOGIES.Views.Shared
{
    public partial class MainLayout : UserControl
    {
        public MainLayout()
        {
            InitializeComponent();
            MainContentFrame.Navigate(new Uri("/Views/Pages/HomePage.xaml", UriKind.Relative));
        }
        private void NavigateToHome(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("/Views/Pages/HomePage.xaml", UriKind.Relative));
        }

        private void NavigateToSettings(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("/Views/Pages/SettingsPage.xaml", UriKind.Relative));
        }

        private void NavigateToTickets(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("/Views/Pages/TicketsPage.xaml", UriKind.Relative));
        }

        private void NavigateToAbout(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("/Views/Pages/AboutPage.xaml", UriKind.Relative));
        }
        private void NavigateToTocken(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("/Views/Pages/TockenPage.xaml", UriKind.Relative));
        }
    }
}
