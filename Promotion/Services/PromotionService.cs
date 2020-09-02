using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class PromotionService : IPromotionService
    {
        public IList<Promotion> Promotions { get; }

        public PromotionService()
        {
            this.Promotions = new List<Promotion>();
        }

        public void AddPromotion(Promotion promotion)
        {
            if (promotion != null)
            {
                this.Promotions.Add(promotion);
            }
        }

        public IEnumerable<Promotion> GetPromotions()
        {
            return this.Promotions;
        }
    }
}
