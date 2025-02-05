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
using System.Windows.Media.Animation;

namespace FBTECHNOLOGIES.Views.Shared
{
    public partial class MainLayout : UserControl
    {
        private Button _currentActiveButton;

        public MainLayout()
        {
            InitializeComponent();
            SetActiveButton(HomeButton);
            MainContentFrame.Navigate(new Uri("/Views/Pages/HomePage.xaml", UriKind.Relative));
        }
        private void SetActiveButton(Button button)
        {
            if (_currentActiveButton != null)
            {
                var template = _currentActiveButton.Template;
                var icon = template.FindName("ButtonIcon", _currentActiveButton) as Image;
                var text = template.FindName("ButtonText", _currentActiveButton) as TextBlock;

                if (icon != null)
                    icon.Source = _currentActiveButton.Resources["InactiveIcon"] as ImageSource;
                if (text != null)
                    text.Visibility = Visibility.Collapsed;
            }

            // Activate new button
            _currentActiveButton = button;
            var newTemplate = button.Template;
            var newIcon = newTemplate.FindName("ButtonIcon", button) as Image;
            var newText = newTemplate.FindName("ButtonText", button) as TextBlock;

            if (newIcon != null)
                newIcon.Source = button.Resources["ActiveIcon"] as ImageSource;
            if (newText != null)
                newText.Visibility = Visibility.Visible;
        }
        private void NavigateToHome(object sender, RoutedEventArgs e)
        {
            SetActiveButton(sender as Button);
            MainContentFrame.Navigate(new Uri("/Views/Pages/HomePage.xaml", UriKind.Relative));
        }

        private void NavigateToSettings(object sender, RoutedEventArgs e)
        {
            SetActiveButton(sender as Button);
            MainContentFrame.Navigate(new Uri("/Views/Pages/SettingsPage.xaml", UriKind.Relative));
        }

        private void NavigateToTickets(object sender, RoutedEventArgs e)
        {
            SetActiveButton(sender as Button);
            MainContentFrame.Navigate(new Uri("/Views/Pages/TicketsPage.xaml", UriKind.Relative));
        }

        private void NavigateToAbout(object sender, RoutedEventArgs e)
        {
            SetActiveButton(sender as Button);
            MainContentFrame.Navigate(new Uri("/Views/Pages/AboutPage.xaml", UriKind.Relative));
        }
        private void NavigateToTocken(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("/Views/Pages/TockenPage.xaml", UriKind.Relative));
        }
    }
}
