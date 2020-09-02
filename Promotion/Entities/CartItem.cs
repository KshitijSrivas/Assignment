namespace Promotion
{
    /// <summary>
    /// Defines the <see cref="CartItem" />.
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Gets the Product.
        /// </summary>
        public Product Product { get; }

        /// <summary>
        /// Gets the Quantity.
        /// </summary>
        public int Quantity { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartItem"/> class.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <param name="quantity">The quantity<see cref="int"/>.</param>
        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
