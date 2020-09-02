using Promotion.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Promotion
{
    public class CheckoutService : ICheckoutService
    {
        private readonly ICartService cartService;


        private readonly IPromotionService promotionService;


        public CheckoutService(ICartService cartService, IPromotionService promotionService)
        {
            this.cartService = cartService;
            this.promotionService = promotionService;
        }

        public double CalculateTotalAmount()
        {
            double total = 0.0;

            var cartItems = this.cartService.GetCartItems();

            //if no cart item total amount is zero
            if (cartItems == null || !cartItems.Any())
            {
                return total;
            }


            var promotions = this.promotionService.GetPromotions();

            //if no promotions are available total amount is price of product multiplied by its quantity
            if (promotions == null || !promotions.Any())
            {
                foreach (var item in cartItems)
                {
                    total = total + (item.Quantity * item.Product.ProductPrice);
                }

                return total;
            }

            string temp = string.Empty;// = cartItems.SelectMany(x => x.Product.ProductName).ToArray();
            foreach (var a in cartItems)
            {
                for (int i = 0; i < a.Quantity; i++)
                {
                    temp += a.Product.ProductName;
                }
            }

            var tempCharArray = temp.ToCharArray();
            Array.Sort(tempCharArray);
            var cart = string.Join("", tempCharArray);

            foreach (var p in promotions)
            {
                var temp1 = p.Products.Select(x => x.ProductName).ToArray();
                Array.Sort(temp1);
                var ptemp = string.Join("", temp1);
                if (cart.IndexOf(ptemp) > -1)
                {
                    total += p.PromotionalCost;
                    cart = cart.Remove(cart.IndexOf(ptemp), ptemp.Length);
                }
            }

            if (!string.IsNullOrEmpty(cart))
            {
                var a = cart.ToArray();
                foreach (var c in a)
                {
                    var price = cartItems.FirstOrDefault(x => x.Product.ProductName == c.ToString()).Product.ProductPrice;
                    total += price;
                }
            }
            return total;
        }
    }
}
