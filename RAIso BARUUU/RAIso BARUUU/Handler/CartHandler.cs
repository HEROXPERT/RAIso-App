using RAIso_BARUUU.Model;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Handler
{
    public class CartHandler
    {
        public static List<Cart> getCart(int userId)
        {
            return CartRepository.getCarts(userId);
        }

        public static Cart getCartbyStatIdUserId(int statId, int userId)
        {
            return CartRepository.getCartbyStatIdUserId(statId, userId);
        }

        public static void Create(int userId, int statId, int quantity)
        {
            CartRepository.Create(userId, statId, quantity);
        }

        public static void Update(int userId, int statId, int quantity)
        {
            CartRepository.Update(userId, statId, quantity);
        }

        public static void Delete(int statId, int userId)
        {
            CartRepository.Delete(statId, userId);
        }

        public static void DeleteAll(int userId)
        {
            CartRepository.DeleteAll(userId);
        }
    }
}