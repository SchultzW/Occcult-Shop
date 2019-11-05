using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Midterm.Controllers
{
    public class ProductController : Controller
    {
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


    }
}