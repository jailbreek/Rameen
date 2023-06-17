using Raameenn.Factory;
using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Repository
{
    public class RamenRepository
    {
        public static string addRamen(string name, string meatId, string broth, string price)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman ramen = RamenFactory.addRamen(name, meatId, broth, price);
            db.Ramen.Add(ramen);
            db.SaveChanges();
            return "Success!";
        }
        public static string editRamen(string id, string name, string meatId, string broth, string price)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman ramen = db.Ramen.Find(int.Parse(id));
            if (ramen != null)
            {
                ramen = RamenFactory.editRamen(ramen, name, meatId, broth, price);
                db.SaveChanges();
                return "Success!";
            }
            return "Ramen Not Found!";
        }
        public static List<RamenView> displayRamen()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<Raman> ramens = new List<Raman>();
            List<RamenView> vramen = new List<RamenView>();
            ramens = db.Ramen.ToList<Raman>();
            foreach (Raman x in ramens)
            {
                Meat meat = new Meat();
                meat = (from y in db.Meats where x.MeatId == y.Id select y).FirstOrDefault();
                RamenView v = new RamenView(x.Id.ToString(), x.Name, meat.Name, x.Borth, x.Price.ToString());
                vramen.Add(v);
            }
            return vramen;
        }
        public static List<RamenView> selectRamen(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman ramen = new Raman();
            ramen = (from x in db.Ramen where x.Id == id select x).FirstOrDefault();
            Meat meat = new Meat();
            meat = (from y in db.Meats where ramen.MeatId == y.Id select y).FirstOrDefault();
            RamenView v = new RamenView(ramen.Id.ToString(), ramen.Name, meat.Name, ramen.Borth, ramen.Price.ToString());
            List<RamenView> vramen = new List<RamenView>();
            vramen.Add(v);
            return vramen;
        }
    }
}