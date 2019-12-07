using Microsoft.EntityFrameworkCore;
using Midterm.Models;
using OccultShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Infrastructure
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(
           DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

    }
}
