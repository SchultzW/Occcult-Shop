using Midterm.Infrastructure;
using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OccultShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int CartItemId { get; set; }
        // public int CartId { get; set; }

        private AppDbContext context;

        public IQueryable<CartItem> CartItems
        {
            get
            {
                return context.CartItems;
            }
        }
    }
}
