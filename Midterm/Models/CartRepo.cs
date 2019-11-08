using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class CartRepo
    {
        private static List<CartItem> carts = new List<CartItem>();
        public static List<CartItem> Carts { get { return carts; } }

        public void AddToCart(CartItem cartItem)
        {
            carts.Add(cartItem);
        }
        
    }
    public class CartItem
    {
        public Product CartProd { get; set; }
        public int Quantity { get; set; }
    }
}
