using System.Windows;
using System.Windows.Input;

namespace Desktop.Window
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class MainEmptyWindow
    {
        private string _name;
        public MainEmptyWindow(string name = "")
        {
            _name = name;
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            CreateWindow vhod = new CreateWindow(_name);
            vhod.Show();
            Close();
        }
    }
   
}
