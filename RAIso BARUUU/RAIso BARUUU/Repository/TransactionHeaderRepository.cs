using RAIso_BARUUU.Factory;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Repository
{
    public class TransactionHeaderRepository
    {
        public static Database1Entities2 db = DatabaseSingleton.getInstance();

        public static List<TransactionHeader> getTransactionHeader()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public static TransactionHeader Create(int userId)
        {
            int transId = generateId();
            TransactionHeader th = TransactionHeaderFactory.Create(transId, userId, DateTime.Now);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            return th;
        }

        private static int generateId()
        {
            int latestId = (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
            return latestId == 0 ? 1 : latestId + 1;
        }

        public static TransactionHeader getThbyUserId(int userId)
        {
            return (from x in db.TransactionHeaders where x.UserID == userId select x).FirstOrDefault();
        }

        public static List<TransactionHeader> getTransactionHeaderByUserId(int userId)
        {
            return (from x in db.TransactionHeaders where x.UserID == userId select x).ToList();
        }
    }
}