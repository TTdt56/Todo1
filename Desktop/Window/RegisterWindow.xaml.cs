using System.Windows;
using Desktop.Model;
using Desktop.Repository;

namespace Desktop.Window
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class RegisterWindow
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Zareg(object sender, RoutedEventArgs e)
        {
            if (Validator.Name(name) == false)
            {
                MessageBox.Show("Неккоректный ввод имени");
            }
            else
            {
                if (Validator.PochtaValid(pochta) == false)
                {
                    MessageBox.Show("Неккоректный ввод почты");
                }
                else
                {
                    if (Validator.PassregValid(passreg) == false)
                    {
                        MessageBox.Show("Неккоректный ввод пароля");
                    }
                    else
                    {
                        if (Validator.PassregandpovtValid(passregpovt, passreg) == false)
                        {
                            MessageBox.Show("Пароли не повтряются");
                        }
                        else
                        {
                            var registerUser = new UserModel(name.Text, pochta.Text, passreg.Text);
                            if (UserRepository.RegisterUser(registerUser) == null)
                            {
                                var window3 = new MainEmptyWindow(name.Text);
                                window3.Show();
                                Close();
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
            LoginWindow glavmenu = new LoginWindow();
            glavmenu.Show();
            Close();
        }
    }

}
