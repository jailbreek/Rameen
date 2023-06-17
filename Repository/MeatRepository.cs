using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Repository
{
    public class MeatRepository
    {
        public static List<Meat> displayMeat()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<Meat> meats = new List<Meat>();
            meats = db.Meats.ToList<Meat>();
            return meats;
        }
    }
}