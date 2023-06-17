using Raameenn.Factory;
using Raameenn.Model;
using Raameenn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Handler
{
    public class UserHandler
    {
        public static void RegisUser(string username, string email, string gender, int roleId, string password)
        {
            User user = UserFactory.RegisUser(username, email, gender, roleId, password);
            UserRepository.InsertUser(user);
        }
        public static User GetUser(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }

        public static List<User> GetUserByRole(string role)
        {
            return UserRepository.GetUserByRole(role);
        }
        public static bool UpdateUser(int id, string new_username, string new_email, string new_gender)
        {
            return UserRepository.Update(id, new_username, new_email, new_gender);
        }
        public static User GetUserById(int id)
        {
            return UserRepository.GetUserById(id);
        }
    }
}
