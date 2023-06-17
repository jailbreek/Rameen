using Raameenn.Model;
using Raameenn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Handler
{
    public class RamenHandler
    {
        public static string addRamen(string name, string meatId, string broth, string price)
        {
            return RamenRepository.addRamen(name, meatId, broth, price);
        }
        public static string editRamen(string id, string name, string meatId, string broth, string price)
        {
            return RamenRepository.editRamen(id, name, meatId, broth, price);
        }

        public static List<RamenView> displayRamen()
        {
            return RamenRepository.displayRamen();
        }
        //public static Raman selectRamen(int id)
        //{
        //    Raman x = RamenRepository.selectRamen(id);
        //    rer
        //}
    }
}