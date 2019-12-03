using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class Product
    {
        private List<Review> reviews = new List<Review>();
        public List<Review> Reviews { get { return reviews; } }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price{ get; set; }
        public string Tag { get; set; }
        public string imgPath { get; set; }
        public bool IsNew { get; set; }

       






    }
}
