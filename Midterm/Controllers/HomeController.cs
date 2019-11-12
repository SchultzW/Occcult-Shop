using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Infrastructure;
using Midterm.Models;
using System.Web;

namespace Midterm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<int> Ids = new List<int>();
            Ids = RandomProds();
            List<Product> myList = new List<Product>();
          
            
            foreach(int id in Ids)
            {
                Product p = ProdRepo.GetProdByID(id);
                myList.Add(p);
            }


            return View(myList);
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
        private List<int> RandomProds()
        {
            
            if(ProdRepo.Count()==0)
            {
                
                FillRepo();
                
            }
            int num = ProdRepo.Count();
            Random random = new Random();
            List<int> Ids = new List<int>();
            var myNums= Enumerable.Range(1, num).ToArray();

            //randomize array of numbers
            for(int i =0 ; i < myNums.Length; ++i)
{
                int randomIndex = random.Next(myNums.Length);
                int temp = myNums[randomIndex];
                myNums[randomIndex] = myNums[i];
                myNums[i] = temp;
            }
            //take numbers for IDs
            for(int i=0;i<=2;i++)
            {
                Ids.Add(myNums[i]); 
            }

            return Ids;
            
           
        }

        public void FillRepo()
        {
            Product p = new Product();
            Product p1 = new Product();
            Product p2 = new Product();

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

