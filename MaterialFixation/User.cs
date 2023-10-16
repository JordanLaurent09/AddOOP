using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialFixation
{
    class User:IUser
    {
        private string _userDataPath = Directory.GetCurrentDirectory() + "\\userData.txt";

        public  int Id { private get; set; }
        public string Name { private get; set; }

        public string Login { private get; set; }

        public string Password { private get; set; }


        public User(string name, string login, string password)
        {
            string[] users = File.ReadAllLines(_userDataPath);
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Split(" ")[2] == login)
                {
                    Console.WriteLine("Такой пользователь уже есть");
                    return;
                }
            }
            Id = users.Length;

            Name = new IsDataExists((data) =>
            {
                if (data == null || data == "")
                {
                    throw new Exception("Нет данных");
                }
                return data;
            })(name);

            Login = new IsDataExists((data) =>
            {
                if (data == null || data == "")
                {
                    throw new Exception("Нет данных");
                }
                return data;
            })(login);
            Password = new IsDataExists((data) =>
            {
                if (data == null || data == "")
                {
                    throw new Exception("Нет данных");
                }
                return data;
            })(password);

            string totalUserInfo = Id + " " + Name + " " + Login +  " " + Password;
            SaveData(totalUserInfo);

        }


        public void SaveData(string userData)
        {
            File.AppendAllText(_userDataPath, userData);
            
            //List<string> userData = File
            //string[] userData = {Id + "", Name, Login, Password};
            //File.WriteAllLines("Test.txt", userData);
        }
    }






    // Создание интерфейса 

    public interface IUser
    {
        public int Id { set; }
        public string Name { set; }

        public string Login { set; }

        public string Password { set; }
    }

    public delegate string IsDataExists(string data);
}
