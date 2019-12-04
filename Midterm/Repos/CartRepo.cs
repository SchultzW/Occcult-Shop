//using Midterm.Infrastructure;
//using OccultShop.Models;
//using OccultShop.Repos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Midterm.Models
//{
//    public class Cart:ICartRepo
//    {
//        private AppDbContext context;
//        public IQueryable<Cart> Carts
//        {
//            get
//            {
//                return context.Carts;
//            }
//        }

//        //private static List<CartItem> carts = new List<CartItem>();
//        //public static List<CartItem> Carts { get { return carts; } }

//        public int CartId { get; set; }
//        public int CartItemId { get; set; }


//        public void AddToCart(CartItem cartItem)
//        {
//            context.Add(cartItem);
//            context.SaveChanges();
//        }
        
//    }
  

//}
