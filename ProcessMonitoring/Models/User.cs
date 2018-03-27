using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using StackExchange.Redis;

namespace ProcessMonitoring.Models
{
    public class User
    {

        private string login;
        private string password;
        private bool isAdmin;

        public User(string login, string password, bool isAdmin)
        {
            this.login = login;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public User(string login, bool isAdmin)
        {
            this.login = login;
            this.isAdmin = isAdmin;
        }

        public void save()
        {
            var user = DBConnection.db.HashGet(login, "password");
            if (!user.IsNullOrEmpty)
            {
                throw new Exception("This user already exist");
            }
            var info = new[] { new HashEntry("password", GetHashString(password)), new HashEntry("isAdmin", isAdmin) };
            DBConnection.db.HashSet(login, info);
        }

        public static User getUser(string login, string password)
        {
            var pass = DBConnection.db.HashGet(login, "password");
            if (pass != GetHashString(password))
            {
                throw new Exception("Password invalid");
            }
            return new User(login, (bool)DBConnection.db.HashGet(login, "isAdmin"));
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

    }
}
