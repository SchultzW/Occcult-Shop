using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Infrastructure;

namespace Midterm.Models
{
    public class Review
    {
        private AppDbContext context;
        public IQueryable<Review> Reviews
        {
            get
            {
                return context.Reviews;
            }
        }
        public string Author { get; set; }
        public string ReviewText { get; set; }
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
    }
}
