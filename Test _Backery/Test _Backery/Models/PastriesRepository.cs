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
                return _appDbContext.Pastries.Include(c => c.Category);
            }
        }

        public IEnumerable<Pastries> PastriesOfTheWeek
        {
            get
            {
                return _appDbContext.Pastries.Include(c => c.Category).Where(p => p.IsbackeryOfTheWeek);
            }
        }

        public Pastries GetPastriesById(int pastriesId)
        {

            return _appDbContext.Pastries.FirstOrDefault(p => p.IsbackeryOfTheWeek);

        }
    }
    //
}
