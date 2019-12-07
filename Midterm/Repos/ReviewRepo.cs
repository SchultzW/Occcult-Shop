using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Infrastructure;
using Midterm.Models;
using Midterm.Repos;

namespace Midterm.Models
{
    public class ReviewRepo : IReviewRepo
    {
        private AppDbContext context;

        public IQueryable<Review> Reviews
        {
            get
            {
                return context.Reviews;
            }
            
        }
        public ReviewRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddReview(Review r)
        {
            context.Reviews.Add(r);
            context.SaveChanges();
        }

        public void RemoveReview(Review r)
        {
            context.Remove(r);
            context.SaveChanges();
        }
    }
}
