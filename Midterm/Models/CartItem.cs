using Midterm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OccultShop.Models
{
    public class CartItem
    {
           
            
            public int CartItemID { get; set; }
            public Product CartProd { get; set; }
            public int Quantity { get; set; }
            //public string userid
        
    }
}
