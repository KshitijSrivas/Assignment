namespace Promotion.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ICartService" />.
    /// </summary>
    public interface ICartService
    {
        /// <summary>
        /// The AddCartItem.
        /// </summary>
        /// <param name="CartItem">The CartItem<see cref="CartItem"/>.</param>
        void AddCartItem(CartItem CartItem);

        /// <summary>
        /// The GetCartItems.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{CartItem}"/>.</returns>
        IEnumerable<CartItem> GetCartItems();
    }
}
