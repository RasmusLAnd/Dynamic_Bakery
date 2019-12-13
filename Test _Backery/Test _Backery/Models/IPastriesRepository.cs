using System.Collections.Generic;

namespace Test__Backery.Models
{
    public interface IPastriesRepository
    {
        IEnumerable<Pastries> AllPastries { get; }
        IEnumerable<Pastries> PastriesOfTheWeek { get; }
        Pastries GetPastriesById(int pastriesId);
    }
}
