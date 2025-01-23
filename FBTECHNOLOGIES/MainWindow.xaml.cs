using System.Globalization;
using System;
using System.Windows;
using System.Windows.Data;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace FBTECHNOLOGIES
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //PopulateRectangleProgress(Stage1ProgressGrid, 15, 20); 
            //PopulateRectangleProgress(StockProgressGrid, 8, 20);  

        }

        private void runBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
