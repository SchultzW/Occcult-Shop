using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Midterm.Infrastructure;
using Midterm.Repos;
using OccultShop.Repos;
using OccultShop.Models;

namespace Midterm.Controllers
{
    public class ProductController : Controller
    {
        
        IProdRepos pRepo;
        ICartItemRepo cRepo;
       
        //Product p = new Product();
        //Product p1 = new Product();
        //Product p2 = new Product();
        //Product p3 = new Product();
        //Product p4 = new Product();

        public ProductController(IProdRepos r,ICartItemRepo c)
        {
            cRepo = c;
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

            //pRepo.Prods.
            //FillRepo(tag);

            IEnumerable<Product> products = (from product in pRepo.Products
                                             where product.Tag == tag
                                             select product).ToList();

            //List < Product > prods = pRepo.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public ViewResult ProductDetails(int ID)
        {
            IEnumerable<Product> products = (from product in pRepo.Products
                                             where product.ProductId == ID
                                             select product).ToList();
            Product p = products.ElementAt(0);
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

            
        //    //List<Cart> cart = Cart.Carts;
        //    List<CartItem> cart = Cart.Carts;
            
            
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
                //review.ProdId = ID;

                Product p = pRepo.GetProdByID(ID);
                p.Reviews.Add(review);
                
                return View("Browse");
            }
            else if (Command == "AddCart")
            {

                CartItem item = new CartItem();
                Product p = new Product();
                p = pRepo.GetProdByID(id);

               
                item.Product = p;
                item.Quantity = quantity;

                cRepo.AddItem(item);
               
                
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