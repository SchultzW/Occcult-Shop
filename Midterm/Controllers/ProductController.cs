using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Midterm.Infrastructure;
using static Midterm.Models.CartRepo;
using Midterm.Repos;

namespace Midterm.Controllers
{
    public class ProductController : Controller
    {
        
        IProdRepos pRepo;
        Product p = new Product();
        Product p1 = new Product();
        Product p2 = new Product();
        Product p3 = new Product();
        Product p4 = new Product();

        public ProductController(IProdRepos r)
        {
            pRepo = r;
        }

        List<Product> allProds = new List<Product>();
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
            if(allProds.Count==0)
            {
                FillAllProds();
            }
            pRepo.Prods.Clear();
            FillRepo(tag);
          
                            
            List<Product> prods = pRepo.Prods;
            return View(prods);
        }
        [HttpGet]
        public ViewResult ProductDetails(int ID)
        {
            Product p = pRepo.GetProdByID(ID);
            
            return View(p);
        }
        /// <summary>
        /// for adding to cart
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpPost]
        //public IActionResult ProductDetails(int quantity, int id)
        //{
        //    CartItem item = new CartItem();
        //    Product p = new Product();
        //    p = pRepo.GetProdByID(id);
        //    item.CartProd = p;
        //    item.Quantity = quantity;

            
        //    //List<CartRepo> cart = CartRepo.Carts;
        //    List<CartItem> cart = CartRepo.Carts;
            
            
        //    cart.Add(item);
        //    SaveCart(cart);
        //    return View("PurchaseConfirm",p);

            
        //}
        [HttpPost]
        public IActionResult ProductDetails(string Name,string reviewText, int ID,string Command,int quantity, int id)
        {
            if (Command == "AddReview")
            {
                Review review = new Review();
                review.Author = Name;
                review.ReviewText = reviewText;
                review.ProdId = ID;

                Product p = pRepo.GetProdByID(ID);
                p.Reviews.Add(review);

                return View("Browse");
            }
            else if (Command == "AddCart")
            {

                CartItem item = new CartItem();
                Product p = new Product();
                p = pRepo.GetProdByID(id);
                item.CartProd = p;
                item.Quantity = quantity;


                //List<CartRepo> cart = CartRepo.Carts;
                List<CartItem> cart = CartRepo.Carts;


                cart.Add(item);
                SaveCart(cart);
                return View("PurchaseConfirm", p);
            }
            else
                return null;



        }
       

        /// <summary>
        /// fills repo with prods that match the tag
        /// </summary>
        /// <param name="tag"></param>
        public void FillRepo(string tag)
        {
            foreach(Product p in allProds)
            {
                if(p.Tag==tag)
                {
                    pRepo.AddProd(p);
                }
            }

        }

        /// <summary>
        /// test data so product doesnt throw null
        /// </summary>
        public void FillAllProds()
        {
            p1.Title = "Prod 1 Books";
            p1.ID = 1;
            p1.Price = 1;
            p1.Tag = "Books";
            p1.Description = "Test Prod 1";
            p1.imgPath = "http://placekitten.com/g/201/300";

            p2.Title = "Prod 2 Books";
            p2.ID = 2;
            p2.Price = 2;
            p2.Tag = "Books";
            p2.Description = "Test Prod 2";
            p2.imgPath = "http://placekitten.com/g/202/300";

            p.Title = "Prod 3 Books";
            p.ID = 3;
            p.Price = 3;
            p.Tag = "Books";
            p.Description = "Test Prod 3";
            p.imgPath = "http://placekitten.com/g/203/300";

            p3.Title = "Prod 4 Home";
            p3.ID = 4;
            p3.Price = 4;
            p3.Tag = "Home";
            p3.Description = "Test Prod 4";
            p3.imgPath = "http://placekitten.com/g/204/300";

            p4.Title = "Prod 5 Home";
            p4.ID = 5;
            p4.Price = 5;
            p4.Tag = "Decor";
            p4.Description = "Test Prod 5";
            p4.imgPath = "http://placekitten.com/g/204/300";


            allProds.Add(p);
            allProds.Add(p2);
            allProds.Add(p2);
            allProds.Add(p3);
            allProds.Add(p4);

        }

        /// <summary>
        /// session stuff doenst work at the moment >_<
        /// </summary>
        /// <returns></returns>
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