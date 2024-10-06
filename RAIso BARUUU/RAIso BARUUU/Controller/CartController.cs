using RAIso_BARUUU.Handler;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;

namespace RAIso_BARUUU.Controller
{
    public class CartController
    {
        public static String addCart(int userId, int statId, int quantity)
        {
            if (quantity <= 0)
            {
                return "Quantity needs to be at least 1!";
            }
            CartHandler.Create(userId, statId, quantity);
            return null;
        }

        public static String UpdateCart(int userId, int statId, int quantity)
        {
            Cart cart = CartHandler.getCartbyStatIdUserId(statId, userId);

            if (quantity <= 0)
            {
                return "Quantity needs to be at least 1!";
            }
            CartHandler.Update(userId, statId, quantity);
            return null;
        }

        public static String DeleteCart(int statId, int userId)
        {
            Cart cart = CartHandler.getCartbyStatIdUserId(statId, userId);
            if (cart == null)
            {
                return "Item not found!";
            }

            CartHandler.Delete(statId, userId);
            return null;
        }

        public static List<Cart> getCarts(int userId)
        {
            return CartHandler.getCart(userId);
        }

        public static Cart getCartbyStatIdUserId(int statId, int userId)
        {
            return CartHandler.getCartbyStatIdUserId(statId, userId);
        }

        public static void DeleteAll(int userId)
        {
            CartHandler.DeleteAll(userId);
        }
    }
}