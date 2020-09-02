using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Assignment
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

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var CartItem in cartItems)
            {
                if (count.ContainsKey(CartItem.Product.ProductName))
                {
                    count[CartItem.Product.ProductName] = count[CartItem.Product.ProductName] + 1;
                }
                else
                {
                    count.Add(CartItem.Product.ProductName, 1);
                }
            }

            foreach (var promo in promotions)
            {

            }

            return 0.0;
        }
    }
}
