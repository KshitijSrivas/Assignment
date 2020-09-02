using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion.Interfaces
{
    public interface ICartService
    {
        void AddCartItem(CartItem CartItem);

        IEnumerable<CartItem> GetCartItems();
    }
}
