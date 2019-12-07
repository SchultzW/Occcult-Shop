using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Repos
{
    public interface IReviewRepo
    {
         IQueryable<Review> Reviews { get; }
        void AddReview(Review r);
        void RemoveReview(Review r);
    }
}
