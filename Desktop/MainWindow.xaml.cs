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
using Desktop.Model;
using System.Text.RegularExpressions;
using Desktop.Repository;

namespace Desktop
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
        private void Voiti(object sender, RoutedEventArgs e)
        {
            if (Validator.EmailValid(Login) == false)
            {
                MessageBox.Show("Неккоректный ввод почты");
            }
            else
            {
                if (Validator.PasswordValid(PasswordBox) == false)
                {
                    MessageBox.Show("Неккоректный ввод пароля");
                }
                else
                {
                    var loginuser = new UserModel("", Login.Text, "");
                    if (UserRepository.CheckUser(loginuser) == null)
                    {
                        var passuser = new UserModel("", "", PasswordBox.Password);
                        if (UserRepository.Checkpass(passuser) == null)
                        {

                            Window2 vhod = new Window2();
                            vhod.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Пароль неверный");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                    }
                }
            }
        }
        private void Registracia(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            reg.Show();
            Close();
        }  
    }
    public static class Validator
    {
        public static bool EmailValid(TextBox Login)
        {
            Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            Match match = regex.Match(Login.Text);

            if (match.Success)
                return true;
            else
                return false;
        }
        public static bool PasswordValid(PasswordBox PasswordBox)
        {
            if (PasswordBox.Password.Length >= 6)
                return true;
            else
                return false;
        }
        public static bool Name(TextBox name)
        {
            if (name.Text.Length >= 3)
                return true;
            else
                return false;
        }
        public static bool PochtaValid(TextBox pochta)
        {
            Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            Match match = regex.Match(pochta.Text);

            if (match.Success)
                return true;
            else
                return false;
        }
        public static bool PassregValid(TextBox passreg)
        {
            if (passreg.Text.Length >= 6)
                return true;
            else
                return false;
        }
        public static bool PassregandpovtValid(TextBox passregpovt, TextBox passreg)
        {
            if (passregpovt.Text == passreg.Text)
                return true;
            else
                return false;
        }
    }
}