using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Model
{
    public class detailView
    {
        public string customerName { get; set; }
        public string staffName { get; set; }
        public string ramenName { get; set; }
        public string ramenMeat { get; set; }
        public string ramenBroth { get; set; }
        public string ramenPrice { get; set; }
        public DateTime datetime { get; set; }

        public detailView(string Customername, string Staffname, string Ramenname, string Ramenmeat, string Ramenbroth, string Ramenprice, DateTime dDatetime)
        {
            customerName = Customername;
            staffName = Staffname;
            ramenName = Ramenname;
            ramenMeat = Ramenmeat;
            ramenBroth = Ramenbroth;
            ramenPrice = Ramenprice;
            datetime = dDatetime;
        }
    }
}