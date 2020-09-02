using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Promotion
    {
        public IList<Product> Products { get; }

        public double PromotionalCost { get; set; }

        public Promotion()
        {
            Products = new List<Product>();
        }
    }
}
