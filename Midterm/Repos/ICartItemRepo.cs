using OccultShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OccultShop.Repos
{
    public interface ICartItemRepo
    {
        IQueryable<CartItem> CartItems { get; }
        void AddItem(CartItem item);
        void RemoveItem(CartItem item);
     
    }
}
