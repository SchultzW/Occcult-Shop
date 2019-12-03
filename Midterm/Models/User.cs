using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class User
    {
        private static List<Cart> cart = new List<Cart>();
        public static List<Cart> Cart { get { return cart; } }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
    }
}
