using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Model
{
    public class RamenView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Meat { get; set; }
        public string Broth { get; set; }
        public string Price { get; set; }
        public RamenView(string id, string name, string meat, string broth, string price)
        {
            Id = id;
            Name = name;
            Meat = meat;
            Broth = broth;
            Price = price;
        }
    
    }
}