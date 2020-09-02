namespace Promotion
{
    using Promotion.Interfaces;
    using System;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="CheckoutService" />.
    /// </summary>
    public class CheckoutService : ICheckoutService
    {
        /// <summary>
        /// Defines the cartService.
        /// </summary>
        private readonly ICartService cartService;

        /// <summary>
        /// Defines the promotionService.
        /// </summary>
        private readonly IPromotionService promotionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutService"/> class.
        /// </summary>
        /// <param name="cartService">The cartService<see cref="ICartService"/>.</param>
        /// <param name="promotionService">The promotionService<see cref="IPromotionService"/>.</param>
        public CheckoutService(ICartService cartService, IPromotionService promotionService)
        {
            this.cartService = cartService;
            this.promotionService = promotionService;
        }

        /// <summary>
        /// The CalculateTotalAmount.
        /// </summary>
        /// <returns>The <see cref="double"/>.</returns>
        public double CalculateTotalAmount()
        {
            double total = 0.0;
            var cartItems = this.cartService.GetCartItems();

            // If no cart item total amount is zero.
            if (cartItems == null || !cartItems.Any())
            {
                return total;
            }

            var promotions = this.promotionService.GetPromotions();

            // If no promotions are available total amount is price of product multiplied by its quantity.
            if (promotions == null || !promotions.Any())
            {
                foreach (var item in cartItems)
                {
                    total += item.Quantity * item.Product.ProductPrice;
                }

                return total;
            }

            string itemNames = string.Empty;
            foreach (var item in cartItems)
            {
                for (int i = 0; i < item.Quantity; i++)
                {
                    itemNames += item.Product.ProductName;
                }
            }

            var cartCharArray = itemNames.ToCharArray();
            Array.Sort(cartCharArray);
            var concatenatedItemNames = string.Join("", cartCharArray);

            foreach (var promotion in promotions)
            {
                var promotionProductNames = promotion.Products.Select(x => x.ProductName).ToArray();
                Array.Sort(promotionProductNames);
                var concatenatedProductNames = string.Join("", promotionProductNames);
                while (concatenatedItemNames.IndexOf(concatenatedProductNames) > -1)
                {
                    total += promotion.PromotionalCost;
                    concatenatedItemNames = concatenatedItemNames.Remove(concatenatedItemNames.IndexOf(concatenatedProductNames), concatenatedProductNames.Length);
                }
            }

            if (!string.IsNullOrEmpty(concatenatedItemNames))
            {
                foreach (var item in concatenatedItemNames.ToArray())
                {
                    var price = cartItems.FirstOrDefault(x => x.Product.ProductName == item.ToString()).Product.ProductPrice;
                    total += price;
                }
            }

            return total;
        }
    }
}
