using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class ProdRepo
    {
        private static list<Product> prods = new list<Product>();
        public static list<Product> Prods { get { return prods; } }
        

        public static void AddProd(Product p)
        {
            prods.Add(p);
        }
        public static Product GetProdByID(int id)
        {
            Product p = prods.Find(p => p.id == id);
            return p;
        }
        public static Product GetProdByTag(string tag)
        {
            Product p = prods.Find(p => p.tag == tag);
            return p;
        }

    }
}
