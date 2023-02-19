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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();
        }

        private void Button_entrance(object sender, RoutedEventArgs e)
        {
            if (Validator.Emailvalid0(Email) == false)
            {
                MessageBox.Show("Введите почту");
            }
            else if(Validator.Emailvalid(Email) == false)
            {
                MessageBox.Show("Неправильная почта");
            }
            else if (Validator.Passvalid0(Password) == false)
            {
                MessageBox.Show("Введите пароль");
            }
            else if (Validator.Passvalid(Password) == false)
            {
                MessageBox.Show("Маленький пароль");
            }
            else
            {
                Main_empty Main_empty = new Main_empty();
                Main_empty.Show();
                this.Close();
            }
        }
    }
}
