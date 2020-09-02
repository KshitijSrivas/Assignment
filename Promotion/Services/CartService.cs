namespace Promotion
{
    using Promotion.Interfaces;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="CartService" />.
    /// </summary>
    public class CartService : ICartService
    {
        /// <summary>
        /// Gets the CartItems.
        /// </summary>
        private IList<CartItem> CartItems { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartService"/> class.
        /// </summary>
        public CartService()
        {
            this.CartItems = new List<CartItem>();
        }

        /// <summary>
        /// The AddCartItem.
        /// </summary>
        /// <param name="CartItem">The CartItem<see cref="CartItem"/>.</param>
        public void AddCartItem(CartItem CartItem)
        {
            if (CartItem != null)
            {
                this.CartItems.Add(CartItem);
            }
        }

        /// <summary>
        /// The GetCartItems.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{CartItem}"/>.</returns>
        public IEnumerable<CartItem> GetCartItems()
        {
            return this.CartItems;
        }
    }
}
