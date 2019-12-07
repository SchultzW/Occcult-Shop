using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;
using OccultShop.Models;
using Microsoft.EntityFrameworkCore;
using Midterm.Infrastructure;

namespace OccultShop.Repos
{
    public class CartItemRepo : ICartItemRepo
    {

        private AppDbContext context;
        public IQueryable<CartItem> CartItems
        {
            get
            {
                return context.CartItems.Include("CartProd");
            }
        }
        public CartItemRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
       public void Add(CartItem c)
        {
            
        }
        public void DeleteItem(CartItem c)
        {
            context.Remove(c);
            context.SaveChanges();
        }

        public void Add(int quantity, Product p)
        {
            CartItem item = new CartItem();
            item.CartProd = p;
            item.Quantity = quantity;
            item.CartItemID = 1;
            context.Add(item);
            context.CartItems.Update(item);
            context.SaveChanges();
        }
      

        public void Remove(CartItem c)
        {
            context.Remove(c);
            //context.CartItems.Update(c);
            context.SaveChanges();
        }
        public List<CartItem>GetCartItems()
        {
            //List<CartItem> cartItems = context.CartItems.Include("Products").ToList();
            List<CartItem> cartItems = context.CartItems.ToList();
            return cartItems;
        }
    }
}
