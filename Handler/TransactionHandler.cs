using Raameenn.Model;
using Raameenn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raameenn.Handler
{
    public class TransactionHandler
    {
        public static List<Header> getAllTransaction()
        {
            return TransactionRepository.getAllTransaction();
        }
    }
}