using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Model
{
    public class historyView
    {
        public string Id { get; set; }
        public string customerName { get; set; }
        public string staffName { get; set; }
        public DateTime dateTime { get; set; }
        public historyView(string id, string Customername, string Staffname, DateTime Datetime)
        {
            Id = id;
            customerName = Customername;
            staffName = Staffname;
            dateTime = Datetime;
        }

    }   
}