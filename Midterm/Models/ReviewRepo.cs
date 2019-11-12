﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;

namespace Midterm.Models
{
    public class ReviewRepo
    {
        private static List<Review> reviews = new List<Review>();
        public static List<Review> Reviews = new List<Review>();

        public void AddReview(Review r)
        {
            reviews.Add(r);
        }

        public List<Review> GetReviewById(int id)
        {
            List<Review> reviews = new List<Review>();
            foreach(Review r in ReviewRepo.reviews)
            {
                if(id==r.ProdId)
                {
                    reviews.Add(r);
                }
            }
            return reviews;
        }
    }
}