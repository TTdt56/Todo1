using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Desktop.Model;
using Desktop.Repository;

namespace Desktop.View
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void Voiti(object sender, RoutedEventArgs e)
        {
            if (check.IsChecked.Value)
            {
                PasswordBox.Password = passv.Text;

            }
            string log = Login.Text;
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
                            NavigationService?.Navigate(new MainEmptyPage("Denis"));
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
            NavigationService?.Navigate(new RegisterPage());
        }
        private void vid(object sender, RoutedEventArgs e)
        {
            passv.Text = PasswordBox.Password;
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                passv.Text = PasswordBox.Password;
                passv.Visibility = Visibility.Visible;
                PasswordBox.Visibility = Visibility.Hidden;
                PasswordBox.Password = passv.Text;

            }
            else
            {
                passv.Visibility = Visibility.Hidden;
                PasswordBox.Visibility = Visibility.Visible;
                passv.Text = PasswordBox.Password;
                PasswordBox.Password = passv.Text;

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
}