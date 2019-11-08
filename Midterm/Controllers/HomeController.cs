using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Infrastructure;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private CartRepo GetCart()
        {
            CartRepo cart = HttpContext.Session.GetJson<CartRepo>("Cart") ?? new CartRepo();
            return cart;
        }

        private void SaveCart(CartRepo cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
    }

}

