using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raameenn.Model;

namespace Raameenn.Repository
{
    public class UserRepository
    {
        static readonly DatabaseEntities db = new DatabaseEntities();
        public static void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public static User GetUser(string username, string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            return user;
        }
        public static User GetUserByUsername(string username)
        {
            return db.Users.FirstOrDefault(x => x.Username == username);
        }

        public static List<User> GetUserByRole(string role)
        {
            return db.Users.Where(x => x.Role.Name == role).ToList();
        }
        public static bool Update(int id, string username, string email, string gender)
        {
            User user = GetUserById(id);

            if (user == null)
            {
                return false;
            }
            else
            {
                user.Username = username;
                user.Email = email;
                user.Gender = gender;

                db.SaveChanges();
                return true;
            }
        }
        public static User GetUserById(int id)
        {
            return db.Users.Find(id);
        }
    }
}