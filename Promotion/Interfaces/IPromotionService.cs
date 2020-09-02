using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public interface IPromotionService
    {
        void AddPromotion(Promotion promotion);

        IEnumerable<Promotion> GetPromotions();
    }
}
