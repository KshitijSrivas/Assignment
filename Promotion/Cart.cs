using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assignment
{
    public class Cart
    {
        public IList<Order> Orders { get; }

        public IList<Promotion> Promotions { get; }

        public Cart()
        {
            this.Orders = new List<Order>();
            this.Promotions = new List<Promotion>();
        }

        public void AddOrder(Order order) 
        { 
            if (order != null)
            {
                this.Orders.Add(order);
            }
        }

        public void AddPromotion(Promotion promotion)
        {
            if (promotion != null)
            {
                this.Promotions.Add(promotion);
            }
        }

        public double CalculateTotalPrice()
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach(var order in Orders)
            {
                if (count.ContainsKey(order.Product.ProductName))
                {
                    count[order.Product.ProductName] = count[order.Product.ProductName] + 1;
                }
                else
                {
                    count.Add(order.Product.ProductName, 1);
                }
            }

            foreach (var promo in this.Promotions) {
               
            }

            return 0.0;
        }
    }
}
