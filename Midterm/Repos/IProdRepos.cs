using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Repos
{
    public interface IProdRepos
    {
        IQueryable<Product> Products { get; }
        //List<Product> Prods { get; }



        void AddProd(Product p);

        Product GetProdByID(int id);

        Product GetProdByTag(string tag);

        int Count();

        void AddReview(Product p, Review r);


        void Clear();

    }
}