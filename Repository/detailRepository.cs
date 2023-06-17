using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Repository
{
    public class detailRepository
    {
        public static List<detailView> displayDetail(int Id)
        {
            DatabaseEntities db = new DatabaseEntities();
            Detail detail = new Detail();
            detail = (from y in db.Details where y.HeaderId == Id select y).FirstOrDefault();
            List<detailView> viewDetails = new List<detailView>();
            Header header = new Header();
            header = (from y in db.Headers where detail.HeaderId == y.Id select y).FirstOrDefault();
            User customer = new User();
            customer = (from v in db.Users where header.CustomerId == v.Id select v).FirstOrDefault();
            User staff = new User();
            staff = (from w in db.Users where header.StaffId == w.Id select w).FirstOrDefault();
            Raman ramen = new Raman();
            ramen = (from z in db.Ramen where detail.RamenId == z.Id select z).FirstOrDefault();
            Meat meat = new Meat();
            meat = (from m in db.Meats where ramen.MeatId == m.Id select m).FirstOrDefault();
            detailView r = new detailView(customer.Username, staff.Username, ramen.Name, meat.Name, ramen.Borth, ramen.Price, header.Date);
            viewDetails.Add(r);

            //foreach (Detail x in details)
            //{
            //    Header header = new Header();
            //    header = (from y in db.Headers where x.HeaderId == y.Id select y).FirstOrDefault();
            //    User customer = new User();
            //    customer = (from v in db.Users where header.CustomerId == v.Id select v).FirstOrDefault();
            //    User staff = new User();
            //    staff = (from w in db.Users where header.StaffId == w.Id select w).FirstOrDefault();
            //    Raman ramen = new Raman();
            //    ramen = (from z in db.Ramen where x.RamenId == z.Id select z).FirstOrDefault();
            //    Meat meat = new Meat();
            //    meat = (from m in db.Meats where ramen.MeatId == m.Id select m).FirstOrDefault();

            //    detailView r = new detailView(customer.Username, staff.Username, ramen.Name, meat.Name, ramen.Borth, ramen.Price, header.Date);
            //    viewDetails.Add(r);
            //}
            return viewDetails;
        }
    }
}