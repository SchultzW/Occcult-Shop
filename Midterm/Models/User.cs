using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class User
    {
        private static List<CartRepo> cart = new List<CartRepo>();
        public static List<CartRepo> Cart { get { return cart; } }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
    }
}
