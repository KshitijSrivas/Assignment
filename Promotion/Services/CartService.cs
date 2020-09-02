using Assignment.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assignment
{
    public class CartService : ICartService
    {
        private IList<CartItem> CartItems { get; }

        public CartService()
        {
            this.CartItems = new List<CartItem>();
        }

        public void AddCartItem(CartItem CartItem) 
        { 
            if (CartItem != null)
            {
                this.CartItems.Add(CartItem);
            }
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return this.CartItems;
        }
    }
}
