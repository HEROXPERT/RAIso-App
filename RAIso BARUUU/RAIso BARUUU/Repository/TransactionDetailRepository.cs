using RAIso_BARUUU.Model;
using System.Collections.Generic;
using System.Linq;

namespace RAIso_BARUUU.Repository
{
    public class TransactionDetailRepository
    {
        public static Database1Entities2 db = DatabaseSingleton.getInstance();

        public static List<TransactionDetail> getTransactionDetail(int transactionId)
        {
            return (from x in db.TransactionDetails where x.TransactionID == transactionId select x).ToList();
        }

        public static void Create(int transactionId, int statId, int quantity)
        {
            TransactionDetail td = new TransactionDetail
            {
                TransactionID = transactionId,
                StationeryID = statId,
                Quantity = quantity
            };
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }
    }
}