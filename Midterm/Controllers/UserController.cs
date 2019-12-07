using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Infrastructure;
using Midterm.Models;
using Midterm.Repos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OccultShop.Models;
using OccultShop.Repos;
using RestSharp;

namespace Midterm.Controllers
{
    public class UserController : Controller
    {
        ICartRepo cRepo;
        ICartItemRepo CIRepo;
        IProdRepos pRepo;

        public UserController(ICartRepo c, ICartItemRepo CI,IProdRepos p)
        {
            CIRepo = CI;
            cRepo = c;
            pRepo = p;
        }
        //public UserController(ICartRepo c)
        //{
           
        //    cRepo = c;
        //}

        public ViewResult Profile()
        {
            return View();
        }
        public ViewResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(string command)
        {
            if(command=="drop")
            {
                cRepo.ClearCart();
                return View("index");
            }
            else
            {
                var cartItems = (from item in CIRepo.CartItems
                                 select item).ToList();
                return View("checkoutconfirm",cartItems);
            }
        }
        [HttpGet]
        public ViewResult Cart()
        {
            //    //var products = (from item in CIRepo.CartItems
            //    //                             select item.CartProd).ToList();

            //    //// var quantity = (from item in CIRepo.CartItems
            //    //                 select item.Quantity).ToList();

            var cartItems = (from item in CIRepo.CartItems
                             select item).ToList();


            return View(cartItems);

            
        }
     
           
            
        [HttpPost]
        public IActionResult Cart(int ID,string command)
        {
            if(command=="checkout")
            {
                var cartItems = (from item in CIRepo.CartItems
                                 select item).ToList();
                return View("Checkoutconfirm");

            }
            else
            {
                var deleteItem =
               (from item in CIRepo.CartItems
                where item.CartItemID == ID
                select item).ToList();

                Product p = deleteItem[0].CartProd;
                CIRepo.Remove(deleteItem[0]);
                return View("DeleteConfirm", p);
            }
           
            
            
            
        }
     
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
        private List<CartItem> GetCart()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            return cart;
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

    }
}