using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Repos
{
   public interface IProdRepos
    {
         
        List<Product> Prods { get; }



        void AddProd(Product p);

        Product GetProdByID(int id);

        Product GetProdByTag(string tag);

        int Count();



        void Clear();
        
    }
}
