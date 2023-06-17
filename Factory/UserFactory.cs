using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Factory
{
    public class UserFactory
    {
        public static User RegisUser(string username, string email, string gender, int roleId, string password)
        {
            User user = new User
            {
                Username = username,
                Email = email,
                Gender = gender,
                RoleId = roleId,
                Password = password
            };

            return user;
        }
    }
}
