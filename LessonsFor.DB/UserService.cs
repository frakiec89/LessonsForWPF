// track

using System.Security.Cryptography;
using System.Text;

namespace LessonsFor.DB
{
    public class UserService
    {
        public void Add (User user)
        {
            using MyDbContext db = new MyDbContext ();
            string salt = Cripto.GetSalt();
            user.Password = Cripto.GetHash(user.Password, salt);
            user.Salt = salt;
            db.Users.Add (user);
            db.SaveChanges ();
        }


        public bool IsUser (string login , string password)
        {
            using MyDbContext db = new MyDbContext();
            try
            {
                User us = db.Users.Single(x => x.Login == login);
                string getHash = Cripto.GetHash(password, us.Salt);

                if(us.Password == getHash)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return  false;
            }
        }
    }

    public class Cripto
    {
        public static string GetHash(string password , string salt)
        {
            MD5 md5 = MD5.Create();
            byte[] intpuByte = Encoding.UTF8.GetBytes(password + salt);
            byte[] bytes = md5.ComputeHash(intpuByte);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public static string GetSalt()
        {
            Random rand = new Random();
            return rand.Next(1000, 20000).ToString();
        }
    }
}
