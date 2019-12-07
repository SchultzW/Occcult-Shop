using System;
using Xunit;
using Midterm.Repos;
using Midterm.Models;
using Microsoft.AspNetCore;
using Midterm.Controllers;
namespace ShopTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddProdRepo()
        {
            //arrange
            var prodRepo = new FakeProdRepo();
            //var controller = new ProductController(prodRepo);
            var p = new Product();

            //act
            p.Description = "test";
            p.imgPath = "test";
            p.IsNew = false;
            p.ProductId = 1;
            p.Tag = "tag";
            p.Title = "test";

            prodRepo.AddProd(p);

            //assert
            Product p2 = prodRepo.GetProdByID(1);
            Assert.Equal("test", p2.Title);

        }
        [Fact]
        public void TestGetById()
        {
            //arrange
            var prodRepo = new FakeProdRepo();
            //var controller = new ProductController(prodRepo);
            var p = new Product();

            //act
            p.Description = "test";
            p.imgPath = "test";
            p.IsNew = false;
            p.ProductId = 1;
            p.Tag = "tag";
            p.Title = "test";

            prodRepo.AddProd(p);

            //assert
            Product p2 = prodRepo.GetProdByID(1);
            Assert.Equal("test", p2.Title);
        }
        [Fact]
        public void AddReview()
        {

            //arrange
            var prodRepo = new FakeProdRepo();
            //var controller = new ProductController(prodRepo);
            var p = new Product();
            var r = new Review();

            //act
            r.Author = "autho";
            r.ReviewID = 1;
            r.ReviewText = "text";
            p.Description = "test";
            p.imgPath = "test";
            p.IsNew = false;
            p.ProductId = 1;
            p.Tag = "tag";
            p.Title = "test";

            prodRepo.AddReview(p, r);
            //assert
            Assert.Equal(1, p.Reviews.Count);
        }
    }
}
