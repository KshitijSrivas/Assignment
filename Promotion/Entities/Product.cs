using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
    public class Product
    {
        public string ProductName { get; }

        public double ProductPrice { get; }

        public Product(string name, double price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
        }
    }
}
