using RAIso_BARUUU.Factory;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RAIso_BARUUU.Repository
{
    public class CartRepository
    {
        public static Database1Entities2 db = DatabaseSingleton.getInstance();

        public static List<Cart> getCarts(int userId)
        {
            return (from x in db.Carts where x.UserID == userId select x).ToList();
        }

        public static int getlastId()
        {
            return (from x in db.Carts select x.UserID).ToList().LastOrDefault();
        }

        public static Cart getCartbyStatIdUserId(int statId, int userId)
        {
            return (from x in db.Carts where x.StationeryID == statId && x.UserID == userId select x).FirstOrDefault();
        }

        public static void Create(int userId, int statId, int quantity)
        {
            var user = db.MsUsers.Find(userId);
            var stationery = db.MsStationeries.Find(statId);

            if (user == null)
            {
                throw new Exception($"User with ID {userId} does not exist.");
            }

            if (stationery == null)
            {
                throw new Exception($"Stationery with ID {statId} does not exist.");
            }

            var existingCart = getCartbyStatIdUserId(statId, userId);
            if (existingCart != null)
            {
                existingCart.Quantity += quantity;
            }
            else
            {
                Cart cart = CartFactory.Create(userId, statId, quantity);
                db.Carts.Add(cart);
            }

            db.SaveChanges();
        }

        public static void Update(int userId, int statId, int quantity)
        {
            Cart cart = getCartbyStatIdUserId(statId, userId);
            if (cart == null)
            {
                throw new Exception("Cart not found.");
            }

            cart.Quantity = quantity;
            db.SaveChanges();
        }

        public static void Delete(int statId, int userId)
        {
            Cart cart = getCartbyStatIdUserId(statId, userId);
            if (cart == null)
            {
                throw new Exception("Cart not found.");
            }

            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public static void DeleteAll(int userId)
        {
            var userCarts = getCarts(userId);
            db.Carts.RemoveRange(userCarts);
            db.SaveChanges();
        }
    }
}