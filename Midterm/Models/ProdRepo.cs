using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class ProdRepo
    {
        private static List<Product> prods = new List<Product>();
        public static List<Product> Prods { get { return prods; } }
        
        
       
        public static void AddProd(Product p)
        {
            prods.Add(p);
        }
        public static Product GetProdByID(int id)
        {
            Product prod = prods.Find(p => p.ID == id);
            return prod;
        }
        public static Product GetProdByTag(string tag)
        {
            Product prod = prods.Find(p => p.Tag == tag);
            return prod;
        }
        public static int Count()
        {
            return prods.Count();
        }
        public void Clear()
        {
            prods.Clear();
        }
    }
}
