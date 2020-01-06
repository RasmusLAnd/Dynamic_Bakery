using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test__Backery.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _appDbContext;


        public ReviewRepository(AppDbContext appDbContext)
        {
            
            _appDbContext = appDbContext;   
        }       

        public void CreateReview(Review review)
        {
            _appDbContext.Reviews.Add(review);           
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Review> SelectedReviews
        {
            get
            { return _appDbContext.Reviews; }

        }
        

    }
}
