namespace Promotion
{
    /// <summary>
    /// Defines the <see cref="Product" />.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets the ProductName.
        /// </summary>
        public string ProductName { get; }

        /// <summary>
        /// Gets the ProductPrice.
        /// </summary>
        public double ProductPrice { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="price">The price<see cref="double"/>.</param>
        public Product(string name, double price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
        }
    }
}
