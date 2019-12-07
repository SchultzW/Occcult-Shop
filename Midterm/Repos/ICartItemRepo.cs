using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;
using OccultShop.Models;

namespace OccultShop.Repos
{
    public interface ICartItemRepo
    {
        IQueryable<CartItem> CartItems { get; }
        void Add(CartItem c);
        void Remove(CartItem c);
        void Add(int quantity, Product p);
        List<CartItem> GetCartItems();
    }
}
