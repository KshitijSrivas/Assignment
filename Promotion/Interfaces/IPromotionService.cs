using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
    public interface IPromotionService
    {
        void AddPromotion(PromotionEntity promotion);

        IEnumerable<PromotionEntity> GetPromotions();
    }
}
