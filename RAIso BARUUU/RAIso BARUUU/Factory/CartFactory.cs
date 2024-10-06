using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Factory
{
    public class CartFactory
    {
        public static Cart Create(int userId, int statId, int quantity)
        {
            Cart cart = new Cart();
            cart.UserID = userId;
            cart.StationeryID = statId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}