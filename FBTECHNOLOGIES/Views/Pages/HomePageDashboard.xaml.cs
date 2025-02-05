using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FBTECHNOLOGIES.Views.Pages
{
    /// <summary>
    /// Interaction logic for HomePageDashboard.xaml
    /// </summary>
    public partial class HomePageDashboard : Page
    {
        public HomePageDashboard()
        {
            InitializeComponent();
            PopulateRectangleProgress(Stage1ProgressGrid, 15, 20);
            PopulateRectangleProgress(StockProgressGrid, 8, 20);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void PopulateRectangleProgress(UniformGrid grid, int filledCount, int totalCount)
        {
            // Clear any existing children
            grid.Children.Clear();

            for (int i = 0; i < totalCount; i++)
            {
                var rectangle = new Rectangle
                {
                    Width = 10,
                    Height = 10,
                    Margin = new Thickness(2),
                    Fill = i < filledCount ? Brushes.Cyan : Brushes.Gray, // Filled vs Unfilled colors
                    RadiusX = 2,
                    RadiusY = 2
                };

                grid.Children.Add(rectangle);
            }
        }
    }
}
