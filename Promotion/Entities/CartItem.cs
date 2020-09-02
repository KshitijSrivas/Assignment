using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class CartItem
    {
        public Product Product { get;}

        public int Quantity { get; }

        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
