namespace Promotion
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PromotionEntity" />.
    /// </summary>
    public class PromotionEntity
    {
        /// <summary>
        /// Gets the Products.
        /// </summary>
        public IList<Product> Products { get; }

        /// <summary>
        /// Gets or sets the PromotionalCost.
        /// </summary>
        public double PromotionalCost { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionEntity"/> class.
        /// </summary>
        public PromotionEntity()
        {
            Products = new List<Product>();
        }
    }
}
