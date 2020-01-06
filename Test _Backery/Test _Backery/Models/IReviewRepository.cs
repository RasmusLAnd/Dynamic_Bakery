using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test__Backery.Models
{
    public interface IReviewRepository
    { 
        void CreateReview(Review review);

        public IEnumerable<Review> SelectedReviews { get; }
    }
}
