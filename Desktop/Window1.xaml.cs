﻿using System;
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
using Desktop.Repository;
using Desktop.Model;

namespace Desktop
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
                                var window3 = new Window3();
                                window3.Show();
                                this.Close();
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
            MainWindow glavmenu = new MainWindow();
            glavmenu.Show();
            Close();
        }
    }

}
