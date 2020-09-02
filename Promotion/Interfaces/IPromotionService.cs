namespace Promotion
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IPromotionService" />.
    /// </summary>
    public interface IPromotionService
    {
        /// <summary>
        /// The AddPromotion.
        /// </summary>
        /// <param name="promotion">The promotion<see cref="PromotionEntity"/>.</param>
        void AddPromotion(PromotionEntity promotion);

        /// <summary>
        /// The GetPromotions.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{PromotionEntity}"/>.</returns>
        IEnumerable<PromotionEntity> GetPromotions();
    }
}
