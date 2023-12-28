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