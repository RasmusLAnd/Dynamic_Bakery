using System.Collections.Generic;

namespace Test__Backery.Models
{
    public interface IPastriesRepository
    {
        IEnumerable<Pastries> AllPastries { get; }
        IEnumerable<Pastries> BakeryOfTheWeek { get; }
        Pastries GetPastriesById(int pastriesId);
        public IEnumerable<Review> GetReviewsByPastriesId(int pastriesId);
    }
}
