﻿using Pharm2U.ViewModels;
using System.Windows;

namespace Pharm2U
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set the data context for the main window
            DataContext = IoC.IoCContainer.Get<ApplicationViewModel>();
        }

        //private void Button_Click(object sender, RoutedEventArgs e) => IoC.IoCContainer.Get<ApplicationViewModel>().IsEditMode ^= true;
    }
}
