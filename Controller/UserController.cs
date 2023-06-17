using Raameenn.Factory;
using Raameenn.Handler;
using Raameenn.Model;
using Raameenn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Controller
{
    public class UserController
    {
        public static void RegisUser(string username, string email, string gender, int roleId, string password)
        {
            UserHandler.RegisUser(username, email, gender, roleId, password);
        }
        public static User Login(string username, string password)
        {
            return UserHandler.GetUser(username, password);
        }
        public static List<User> GetAllUserByRole(string role)
        {
            return UserHandler.GetUserByRole(role);
        }
        public static bool Update(int id, string new_username, string new_email, string new_gender)
        {
            return UserHandler.UpdateUser(id, new_username, new_email, new_gender);
        }
        public static User GetUserById(int id)
        {
            return UserHandler.GetUserById(id);
        }
    }
}