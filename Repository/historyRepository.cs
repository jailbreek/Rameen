using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Repository
{
    public class historyRepository
    {
        public static List<historyView> displayHeaders()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<Header> headers = new List<Header>();
            headers = db.Headers.ToList<Header>();
            List<historyView> viewHeader = new List<historyView>();
            foreach(Header x in headers)
            {
                User customer = new User();
                customer = (from y in db.Users where x.CustomerId == y.Id select y).FirstOrDefault();
                User staff = new User();
                staff = (from y in db.Users where x.StaffId == y.Id select y).FirstOrDefault();
                historyView v = new historyView(x.Id.ToString(), customer.Username, staff.Username, x.Date);
                viewHeader.Add(v);
            }
            return viewHeader;
        }
    }
}