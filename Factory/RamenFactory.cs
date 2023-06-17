using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Factory
{
    public class RamenFactory
    {
        public static Raman addRamen(string name, string meatId, string broth, string price)
        {
            Raman x = new Raman();
            x.Name = name;
            x.MeatId = int.Parse(meatId);
            x.Borth = broth;
            x.Price = price;
            return x;
        }
        public static Raman editRamen(Raman ramen, string name, string meatId, string broth, string price)
        {
            Raman x = ramen;
            x.Name = name;
            x.MeatId = int.Parse(meatId);
            x.Borth = broth;
            x.Price = price;
            return x;
        }
    }
}