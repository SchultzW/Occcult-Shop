using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Midterm.Infrastructure;
using Midterm.Models;
using OccultShop.Models;

namespace OccultShop.Repos
{
    public class CartRepo : ICartRepo
    {
        private AppDbContext context;

        public IQueryable Cart
        {
            get
            {
                return context.Carts;
            }
        }

        public CartRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public Cart GetCart()
        {
            //Cart c = context.CartItems.Include("CartItem");

            return null;

        }
        public void ClearCart()
        {
            context.Database.ExecuteSqlCommand("Drop table cart");
        }

        public void AddToCart(CartItem cartItem)
        {
            //context.Carts.Add(cartItem);
            context.Add(cartItem);
            context.SaveChanges();
        }

        public void RemoveFromCart(CartItem cartItem)
        {
            context.Remove(cartItem);
            context.SaveChanges();
        }
        public void AddToCart(Cart c, CartItem item)
        {

        }

        public void DeleteItem(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
