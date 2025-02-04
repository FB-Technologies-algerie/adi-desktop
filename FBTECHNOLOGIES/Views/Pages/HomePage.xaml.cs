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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FBTECHNOLOGIES.Views.Shared;


namespace FBTECHNOLOGIES.Views.Pages
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Frame mainFrame = FindParentFrame();
                if (mainFrame == null)
                {
                    MessageBox.Show("Could not find MainContentFrame");
                    return;
                }

                var dashboardPage = new HomePageDashboard();
                dashboardPage.RenderTransform = new TranslateTransform(0, ActualHeight);

                mainFrame.Navigate(dashboardPage);

                var slideAnimation = new DoubleAnimation
                {
                    From = ActualHeight,
                    To = 0,
                    // Animation Duration
                    Duration = TimeSpan.FromSeconds(0.8), 
                    EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut }
                };

                dashboardPage.RenderTransform.BeginAnimation(TranslateTransform.YProperty, slideAnimation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private Frame FindParentFrame()
        {
            DependencyObject current = this;

            while (current != null)
            {
                current = VisualTreeHelper.GetParent(current);
                if (current is Frame frame && frame.Name == "MainContentFrame")
                {
                    return frame;
                }
            }

            return null;
        }
    }
}
