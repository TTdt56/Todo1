using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Desktop.Model;
using Desktop.Repository;
using Desktop.View;

namespace Desktop.Window
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainControl.Content = new LoginPage();
        }
    }
}