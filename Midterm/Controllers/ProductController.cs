using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Midterm.Infrastructure;

namespace Midterm.Controllers
{
    public class ProductController : Controller
    {
        Product p = new Product();
        Product p1 = new Product();
        Product p2 = new Product();

        List<Product> products = new List<Product>();
        List<CartItem> cart = new List<CartItem>();
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Browse()
        {
            return View();
        }
      
        [HttpGet]
        public ViewResult Products(string tag)
        {
            if(ProdRepo.Prods.Count==0)
            {
                switch (tag)
                {
                    case "Book":
                        FillRepo();
                        break;

                }
            }
          
                            
            List<Product> prods = ProdRepo.Prods;
            return View(prods);
        }
        [HttpGet]
        public ViewResult ProductDetails(int ID)
        {
            Product p = ProdRepo.GetProdByID(ID);
            
            return View(p);
        }
        [HttpPost]
        public ActionResult ProductDetails(int quantity, int id)
        {
            CartItem item = new CartItem();
            Product p = new Product();
            p = ProdRepo.GetProdByID(id);
            item.CartProd = p;
            item.Quantity = quantity;
            
            List<CartItem> cart = CartRepo.Carts;
            cart.Add(item);
            return View(p);

            
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
        




        public void FillRepo()
        {
            p1.Title = "Prod 1";
            p1.ID = 1;
            p1.Price = 1;
            p1.Tag = "Book";
            p1.Description = "Test Prod 1";
            p1.imgPath = "http://placekitten.com/g/201/300";

            p2.Title = "Prod 2";
            p2.ID = 2;
            p2.Price = 2;
            p2.Tag = "Book";
            p2.Description = "Test Prod 2";
            p2.imgPath = "http://placekitten.com/g/202/300";

            p.Title = "Prod 3";
            p.ID = 3;
            p.Price = 3;
            p.Tag = "Book";
            p.Description = "Test Prod 3";
            p.imgPath = "http://placekitten.com/g/203/300";

            ProdRepo.AddProd(p);
            ProdRepo.AddProd(p1);
            ProdRepo.AddProd(p2);

        }
        

    }
}