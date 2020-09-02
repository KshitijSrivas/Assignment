using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Order
    {
        public Product Product { get;}

        public int Quantity { get; }

        public Order(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
