namespace Promotion
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PromotionService" />.
    /// </summary>
    public class PromotionService : IPromotionService
    {
        /// <summary>
        /// Gets the Promotions.
        /// </summary>
        public IList<PromotionEntity> Promotions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionService"/> class.
        /// </summary>
        public PromotionService()
        {
            this.Promotions = new List<PromotionEntity>();
        }

        /// <summary>
        /// The AddPromotion.
        /// </summary>
        /// <param name="promotion">The promotion<see cref="PromotionEntity"/>.</param>
        public void AddPromotion(PromotionEntity promotion)
        {
            if (promotion != null)
            {
                this.Promotions.Add(promotion);
            }
        }

        /// <summary>
        /// The GetPromotions.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{PromotionEntity}"/>.</returns>
        public IEnumerable<PromotionEntity> GetPromotions()
        {
            return this.Promotions;
        }
    }
}
