using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Infrastructure;
using OccultShop.Models;

namespace OccultShop.Repos
{
    public class CartItemRepo : ICartItemRepo
    {
        private AppDbContext context;
        public IQueryable<CartItem> CartItems
        {
            get
            {
                return context.CartItems;
            }
        }

        public void AddItem(CartItem item)
        {
            context.Add(item);
        }

        public void RemoveItem(CartItem item)
        {
            context.Remove(item);
        }
    }
}
