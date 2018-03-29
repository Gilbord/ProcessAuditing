using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using StackExchange.Redis;
using ProcessMonitoring.Utils;

namespace ProcessMonitoring.Models
{
    public class User
    {

        private string login;
        private string password;
        private bool isAdmin;
        private UserSettings rights;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public UserSettings Rights { get => rights; set => rights = value; }

        public User(string login, string password, bool isAdmin, UserSettings rights)
        {
            this.Login = login;
            this.Password = password;
            this.IsAdmin = isAdmin;
            this.Rights = rights;
        }

        public User(string login, bool isAdmin)
        {
            this.Login = login;
            this.IsAdmin = isAdmin;
        }

        public void update()
        {
            var info = new[] {new HashEntry("isAdmin", IsAdmin),
                new HashEntry("save files", Rights.SaveFiles),
                new HashEntry("watch tip", Rights.WatchTip)};
            DBConnection.db.HashSet(this.Login, info);
        }

        public void save()
        {
            for (int i = 0; i < DBConnection.db.ListLength("Users"); i++)
            {
                if (DBConnection.db.ListGetByIndex("Users", i).ToString().Equals(Login))
                {
                    throw new Exception("This user already exist");
                }
            }
            DBConnection.db.ListRightPush("Users", Login);
            var info = new[] {new HashEntry("password", GetHashString(Password)),
                new HashEntry("isAdmin", IsAdmin),
                new HashEntry("save files", Rights.SaveFiles),
                new HashEntry("watch tip", Rights.WatchTip)};
            DBConnection.db.HashSet(this.Login, info);
        }

        public void delete()
        {
            DBConnection.db.ListRemove("Users", this.Login);
            DBConnection.db.HashDelete(this.Login, "password");
            DBConnection.db.HashDelete(this.Login, "isAdmin");
            DBConnection.db.HashDelete(this.Login, "save files");
            DBConnection.db.HashDelete(this.Login, "watch tip");
        }

        public static List<User> getAllUsers()
        {
            var result = new List<User>();
            for (int i = 0; i < DBConnection.db.ListLength("Users"); i++)
            {
                var login = DBConnection.db.ListGetByIndex("Users", i).ToString();
                var password = DBConnection.db.HashGet(login.ToString(), "password");
                var isAdmin = (bool)DBConnection.db.HashGet(login.ToString(), "isAdmin");
                var rights = new UserSettings((bool)DBConnection.db.HashGet(login.ToString(), "save files"),
                    (bool)DBConnection.db.HashGet(login.ToString(), "watch tip"));
                result.Add(new User(login.ToString(), password, isAdmin, rights));
            }
            return result;
        }

        public static User getUser(string login, string password)
        {
            var pass = DBConnection.db.HashGet(login, "password");

            if (pass != GetHashString(password))
            {
                throw new Exception("Password invalid");
            }
            var isAdmin = (bool)DBConnection.db.HashGet(login.ToString(), "isAdmin");
            var rights = new UserSettings((bool)DBConnection.db.HashGet(login.ToString(), "save files"),
                (bool)DBConnection.db.HashGet(login.ToString(), "watch tip"));
            return new User(login, pass , isAdmin, rights);
        }

        private static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        public void getUpdate()
        {
            this.isAdmin = (bool)DBConnection.db.HashGet(login.ToString(), "isAdmin");
            this.Rights = new UserSettings((bool)DBConnection.db.HashGet(login.ToString(), "save files"),
                (bool)DBConnection.db.HashGet(login.ToString(), "watch tip"));
        }

        public override string ToString()
        {
            return this.Login;
        }

    }
}
