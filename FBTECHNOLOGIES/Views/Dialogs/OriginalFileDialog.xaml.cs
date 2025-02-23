﻿using System;
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
using System.Windows.Shapes;

namespace FBTECHNOLOGIES.Views.Dialogs
{
    public partial class OriginalFileDialog : Window
    {
        public OriginalFileDialog()
        {
            InitializeComponent();
        }
        private void YesBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Original file restored!", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
