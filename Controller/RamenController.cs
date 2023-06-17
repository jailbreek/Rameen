using Raameenn.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Controller
{
    public class RamenController
    {
        private static bool invertBool(bool x)
        {
            return !x;
        }
        public static string addRamen(string name, string meatId, string broth, string price)
        {
            if (broth.Equals("") || name.Equals("") || meatId.Equals("") || price.Equals("")) return "please fill all the fied!";
            if (invertBool(name.Contains("Ramen"))) return "Ramen name must contain 'Ramen'";
            if (int.Parse(price) < 3000) return "Minimum Price is 3000";
            return RamenHandler.addRamen(name, meatId, broth, price);

        }
        public static string editRamen(string id, string name, string meatId, string broth, string price)
        {
            if (broth.Equals("") || name.Equals("") || meatId.Equals("") || price.Equals("") || id.Equals("")) return "please fill all the fied!";
            if (invertBool(name.Contains("Ramen"))) return "Ramen name must contain 'Ramen'";
            if (int.Parse(price) < 3000) return "Minimum Price is 3000";
            return RamenHandler.editRamen(id, name, meatId, broth, price);
        }
    }
}