using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OccultShop.Models;

namespace OccultShop.Repos
{
    public interface ICartRepo
    {
        void AddToCart(CartItem cartItem);
        void RemoveFromCart(CartItem cartItem);
        void ClearCart();
        void DeleteItem(CartItem cartItem);
     
    }
}
