using System.Windows;
using System.Windows.Controls;
using Desktop.Model;
using Desktop.Repository;
using Desktop.Window;

namespace Desktop.View
{
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        
        private void Zareg(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Validator.Name(name) == false)
            {
                MessageBox.Show("Неккоректный ввод имени");
            }
            else
            {
                if (LoginPage.Validator.PochtaValid(pochta) == false)
                {
                    MessageBox.Show("Неккоректный ввод почты");
                }
                else
                {
                    if (LoginPage.Validator.PassregValid(passreg) == false)
                    {
                        MessageBox.Show("Неккоректный ввод пароля");
                    }
                    else
                    {
                        if (LoginPage.Validator.PassregandpovtValid(passregpovt, passreg) == false)
                        {
                            MessageBox.Show("Пароли не повтряются");
                        }
                        else
                        {
                            var registerUser = new UserModel(name.Text, pochta.Text, passreg.Text);
                            if (UserRepository.RegisterUser(registerUser) == null)
                            {
                                NavigationService?.Navigate(new MainEmptyPage("Denis"));
                            }
                            else
                            {
                                MessageBox.Show(UserRepository.RegisterUser(registerUser));
                            }
                        }
                    }
                }
            }
        }
        private void Nazad(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new LoginPage());
        }
    }
}