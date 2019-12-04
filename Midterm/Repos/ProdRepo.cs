using Midterm.Infrastructure;
using Midterm.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Midterm.Models
{
    public class ProdRepo:IProdRepos
    {
        private AppDbContext context;
        //private static List<Product> prods = new List<Product>();
        //public List<Product> Prods { get { return prods; } }
        public IQueryable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
        public ProdRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddProd(Product p)
        {
            context.Add(p);
        }
        public Product GetProdByID(int id)
        {
            Product prod = context.Products.First(p => p.ProductId == id);
            return prod;
        }
        //public  Product GetProdByTag(string tag)
        //{
        //    Product prod = context.Products.Find(p => p.Tag == tag);
        //    return prod;
        //}
        public  int Count()
        {
            return context.Products.Count();
        }

        public Product GetProdByTag(string tag)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
        //public void Clear()
        //{
        //    context.Products.clear();
        //}
    }
}
