using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Model;

namespace Desktop.Repository
{
    public static class UserRepository
    {
        private static readonly ObservableCollection<UserModel> Users = new ObservableCollection<UserModel>
        {
            new UserModel("Danila", "danila@mail.com", "123456789")
        };
        public static IEnumerable<UserModel> GetUser() { return Users; }
        public static void AddUser(UserModel user) { Users.Add(user); }
        public static void RemoveUser(UserModel user) { Users.Remove(user); }
        public static string CheckUser(UserModel user)
        {
            foreach (var item in Users)
            {
                if (user.email == item.email)
                {
                    return null;
                }
            }
            return "Такого пользователя не существует!";
        }
        public static string Checkpass(UserModel user)
        {
            foreach (var item in Users)
            {
                if (user.password == item.password)
                {
                    return null;
                }
            }
            return "Пароль неверный";
        }
        public static string RegisterUser(UserModel user)
        {
            foreach (var item in Users)
            {
                if (item.email == user.email)
                {
                    return "Данная почта уже используется!";
                }
            }
            return null;

        }
    }
}
