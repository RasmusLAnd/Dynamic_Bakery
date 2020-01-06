using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Test__Backery.Models
{
    public class PastriesRepository : IPastriesRepository
    {
        private readonly AppDbContext _appDbContext;


        public PastriesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pastries> AllPastries
        {
            get
            {
                return _appDbContext.Pastries;
            }
        }

        public IEnumerable<Pastries> BakeryOfTheWeek
        {
            get
            {
                return _appDbContext.Pastries.Include(c => c.Category).Where(p => p.IsbackeryOfTheWeek);
            }
        }

        public IEnumerable<Review>GetReviewsByPastriesId(int pastriesId)
        {
            return _appDbContext.Reviews.Where(r => r.PastriesId == pastriesId);
        }

        public Pastries GetPastriesById(int pastriesId)
        {
            return _appDbContext.Pastries.FirstOrDefault(p => p.PastriesId == pastriesId);
        }

       

    }
    //
}
