using System.Windows;
using System.Windows.Controls;

namespace Desktop.View
{
    public partial class MainEmptyPage : Page
    {
        private string _name;
        public MainEmptyPage(string name = "")
        {
            _name = name;
            InitializeComponent();
        }
        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new CreatePage());
        }
    }
}