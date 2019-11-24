using Midterm.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Midterm.Models
{
    public class ProdRepo:IProdRepos
    {
        private static List<Product> prods = new List<Product>();
        public  List<Product> Prods { get { return prods; } }
        
        
       
        public void AddProd(Product p)
        {
            prods.Add(p);
        }
        public Product GetProdByID(int id)
        {
            Product prod = prods.Find(p => p.ID == id);
            return prod;
        }
        public  Product GetProdByTag(string tag)
        {
            Product prod = prods.Find(p => p.Tag == tag);
            return prod;
        }
        public  int Count()
        {
            return prods.Count();
        }
        public void Clear()
        {
            prods.Clear();
        }
    }
}
