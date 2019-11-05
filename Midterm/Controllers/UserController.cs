using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            
            
    }
}