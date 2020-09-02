using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
    public class PromotionService : IPromotionService
    {
        public IList<PromotionEntity> Promotions { get; }

        public PromotionService()
        {
            this.Promotions = new List<PromotionEntity>();
        }

        public void AddPromotion(PromotionEntity promotion)
        {
            if (promotion != null)
            {
                this.Promotions.Add(promotion);
            }
        }

        public IEnumerable<PromotionEntity> GetPromotions()
        {
            return this.Promotions;
        }
    }
}
