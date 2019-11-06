using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class ProductController : Controller
    {
        Product p = new Product();
        Product p1 = new Product();
        Product p2 = new Product();

        List<Product> products = new List<Product>();
       
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
        public ViewResult ProductDetails()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Browse(string s)
        {
            return View("Products");
        }
        public Viewresult Products()
        {
            List<Product> prods = ProdRepo.Prods;
            return View(prods);
        }

        public void FillRepo()
        {
            p1.Title = "Prod 1";
            p1.ID = 1;
            p1.Price = 10;
            p1.Tag = "Book";
            p1.Description = "A Prod";
            p1.imgPath = "http://placekitten.com/g/201/300";

            p2.Title = "Prod 2";
            p2.ID = 2;
            p2.Price = 10;
            p2.Tag = "Book";
            p2.Description = "A Prod";
            p2.imgPath = "http://placekitten.com/g/202/300";

            p.Title = "Prod";
            p.ID = 1;
            p.Price = 10;
            p.Tag = "Book";
            p.Description = "A Prod";
            p.imgPath = "http://placekitten.com/g/203/300";

            products.add(p);
            products.add(p1);
            products.add(p2);

        }
        

    }
}