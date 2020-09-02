using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
    public class PromotionEntity
    {
        public IList<Product> Products { get; }

        public double PromotionalCost { get; set; }

        public PromotionEntity()
        {
            Products = new List<Product>();
        }
    }
}
