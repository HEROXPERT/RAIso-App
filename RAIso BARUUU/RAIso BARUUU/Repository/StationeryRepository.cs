using RAIso_BARUUU.Factory;
using RAIso_BARUUU.Model;
using System.Collections.Generic;
using System.Linq;

namespace RAIso_BARUUU.Repository
{
    public class StationeryRepository
    {
        public static Database1Entities2 db = DatabaseSingleton.getInstance();

        public static List<MsStationery> getStationery()
        {
            return (from x in db.MsStationeries select x).ToList();
        }

        public static int generateId()
        {
            int latestId = (from x in db.MsStationeries select x.StationeryID).ToList().LastOrDefault();
            if (latestId == 0)
            {
                return 1;
            }
            latestId++;
            return latestId;
        }

        public static MsStationery getStatbyId(int id)
        {
            return (from x in db.MsStationeries where x.StationeryID == id select x).FirstOrDefault();
        }

        public static MsStationery getStatbyName(string name)
        {
            return (from x in db.MsStationeries where x.StationeryName == name select x).FirstOrDefault();
        }

        public static void Create(string name, int price)
        {
            int id = generateId();
            MsStationery stat = StationeryFactory.Create(id, name, price);
            db.MsStationeries.Add(stat);
            db.SaveChanges();
        }

        public static void Update(int id, string name, int price)
        {
            MsStationery stat = getStatbyId(id);
            stat.StationeryName = name;
            stat.StationeryPrice = price;
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            // Check for dependent records in the Cart table
            var dependentCarts = db.Carts.Where(cart => cart.StationeryID == id).ToList();
            if (dependentCarts.Any())
            {
                db.Carts.RemoveRange(dependentCarts);
                db.SaveChanges();
            }

            // Check for dependent records in the TransactionDetail table
            var dependentTransactionDetails = db.TransactionDetails.Where(td => td.StationeryID == id).ToList();
            if (dependentTransactionDetails.Any())
            {
                db.TransactionDetails.RemoveRange(dependentTransactionDetails);
                db.SaveChanges();
            }

            // Delete the stationery item
            db.MsStationeries.Remove(getStatbyId(id));
            db.SaveChanges();
        }
    }
}