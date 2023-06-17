using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Repository
{
    public class TransactionRepository
    {
        public static List<Header> getAllTransaction()
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.Headers.ToList();
        }
    }
}