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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Back_MainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Registration(object sender, RoutedEventArgs e)
        {
            if (Validator.Namevalid0(Name) == false)
            {
                MessageBox.Show("Введите имя");
            }
            else if (Validator.Namevalid(Name) == false)
            {
                MessageBox.Show("Маленькое имя");
            }
            else if (Validator.Emailvalid0(Email) == false)
            {
                MessageBox.Show("Введите почту");
            }
            else if (Validator.Emailvalid(Email) == false)
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

        

        private void TextBox_password(object sender, TextChangedEventArgs e)
        {

        }







        private void TextBox_repeat_password(object sender, TextChangedEventArgs e)
        {

        }



    }
}
