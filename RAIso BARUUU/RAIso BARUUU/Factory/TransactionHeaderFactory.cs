using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int transId, int userId, DateTime transactionDate)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = transId;
            th.UserID = userId;
            th.TransactionDate = transactionDate;
            return th;
        }
    }
}