using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Infrastructure;
using Midterm.Models;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Midterm.Controllers
{
    public class UserController : Controller
    {
        List<CartItem> cart = new List<CartItem>();

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
            List<CartItem> cart = GetCart();

            return View(cart);
        }
        [HttpPost]
        public IActionResult Cart(string s)
        {
            return View("checkout");
        }
        private List<CartItem> GetCart()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            return cart;
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
        [HttpGet]
        public ViewResult Horoscope()
        {
            return View();
        }
        [HttpPost]
        public RedirectResult Horoscope(string sign)
        {
            var client = new RestClient();

            IRestResponse response = client.Execute(new RestRequest("http://horoscope-api.herokuapp.com/horoscope/today/" + sign));

            var objects = JObject.Parse(response.Content);

            /*
             * need to create a model for response from API so i can pass it 
             * into view
             * 
             * need to update view page so user can choose sign
             * 
             * need to hook up routes to horoscope page.
             * 
             *totalCreditsRemoved = (String)objects.Value["totalCreditsRemoved"];
                invalidReceivers = (String)objects.Value["invalidReceivers"];
                ids = (String)objects.Value["ids"];
                validReceivers = (String)objects.Value["validReceivers"]; 
             * 
             * 
             */

            return null;
        }

    }
}