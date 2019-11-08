using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Infrastructure;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Profile()
        {
            return View();
        }
        public ViewResult Checkout()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Cart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cart(string s)
        {
            return View("checkout");
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