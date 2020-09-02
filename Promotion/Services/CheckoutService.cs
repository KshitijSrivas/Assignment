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

            // if no cart item total amount is zero
            if (cartItems == null || !cartItems.Any())
            {
                return total;
            }

            var promotions = this.promotionService.GetPromotions();

            // if no promotions are available total amount is price of product multiplied by its quantity
            if (promotions == null || !promotions.Any())
            {
                foreach (var item in cartItems)
                {
                    total = total + (item.Quantity * item.Product.ProductPrice);
                }

                return total;
            }

            string cart = string.Empty;
            foreach (var a in cartItems)
            {
                for (int i = 0; i < a.Quantity; i++)
                {
                    cart += a.Product.ProductName;
                }
            }

            var cartCharArray = cart.ToCharArray();
            Array.Sort(cartCharArray);
            var cartValue = string.Join("", cartCharArray);

            foreach (var promotion in promotions)
            {
                var temp = promotion.Products.Select(x => x.ProductName).ToArray();
                Array.Sort(temp);
                var ptemp = string.Join("", temp);
                while (cartValue.IndexOf(ptemp) > -1)
                {
                    total += promotion.PromotionalCost;
                    cartValue = cartValue.Remove(cartValue.IndexOf(ptemp), ptemp.Length);
                }
            }

            if (!string.IsNullOrEmpty(cartValue))
            {
                foreach (var c in cartValue.ToArray())
                {
                    var price = cartItems.FirstOrDefault(x => x.Product.ProductName == c.ToString()).Product.ProductPrice;
                    total += price;
                }
            }

            return total;
        }
    }
}
