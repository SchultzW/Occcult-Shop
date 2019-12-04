using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Infrastructure;
using Midterm.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OccultShop.Models;
using OccultShop.Repos;
using RestSharp;

namespace Midterm.Controllers
{
    public class UserController : Controller
    {
        ICartItemRepo cRepo;
        //List<CartItem> cart = new List<CartItem>();
        
        public UserController(ICartItemRepo r)
        {
            cRepo = r;
        }
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
            IEnumerable<CartItem>cartItems = (from CartItem in cRepo.CartItems
                                              select CartItem).ToList();

            return View(cartItems);
        }
        [HttpPost]
        public IActionResult Cart(string s)
        {
            return View("checkout");
        }
        //private List<CartItem> GetCart()
        //{
        //    List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
        //    return cart;
        //}

        //private void SaveCart(List<CartItem> cart)
        //{
        //    HttpContext.Session.SetJson("Cart", cart);
        //}
        [HttpGet]
        public ViewResult Horoscope()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Horoscope(string sign,string time)
        {
   
           MyHoroscope horoscope = new MyHoroscope();
            var client = new RestClient();

            IRestResponse response = client.Execute(new RestRequest("http://horoscope-api.herokuapp.com/horoscope/"+time+"/" + sign));

            string objects = JObject.Parse(response.Content).ToString();

            horoscope = JsonConvert.DeserializeObject<MyHoroscope>(objects);

            /*
             * Account account = JsonConvert.DeserializeObject<Account>(json);
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

            return View("HoroscopeResult",horoscope);
        }

    }
}