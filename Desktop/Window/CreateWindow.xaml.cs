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
using System.Windows.Shapes;
using Desktop.Window;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class CreateWindow
    {
        private string _name;
        public CreateWindow(string name = "")
        {
            InitializeComponent();
            _name = name;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow(_name);
            mainWindow.Show();
            Close();
        }
    }
}
