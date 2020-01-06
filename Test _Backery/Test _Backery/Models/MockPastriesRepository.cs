using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test__Backery.Models
{
    public class MockPastriesRepository: IPastriesRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pastries> AllPastries =>
            new List<Pastries>
            {
                new Pastries {PastriesId = 1, Name="Håndværker", Price=5M, ShortDescription="NammeNam", LongDescription="Freshly baked with delicious crumb", Category = _categoryRepository.AllCategories.ToList()[0], InStock=true, IsbackeryOfTheWeek=false},
                new Pastries {PastriesId = 2, Name="Smørkage", Price=30M, ShortDescription="Lots of butter", LongDescription="o", Category = _categoryRepository.AllCategories.ToList()[1], InStock=true, IsbackeryOfTheWeek=false},
                new Pastries {PastriesId = 3, Name="Bryllupskage", Price=25000M, ShortDescription="Lorem Ipsum", LongDescription="Wedding time :-)", Category = _categoryRepository.AllCategories.ToList()[2], InStock=true, IsbackeryOfTheWeek=true},
                new Pastries {PastriesId = 4, Name="Baguette", Price=20M, ShortDescription="Long Bread", LongDescription="Long bread from France - the true parisian feeling", Category = _categoryRepository.AllCategories.ToList()[0], InStock=true, IsbackeryOfTheWeek=true}
            };

        public IEnumerable<Pastries> BakeryOfTheWeek { get; }

        public Pastries GetPastriesById(int pastriesId)
        {
            return AllPastries.FirstOrDefault(p => p.PastriesId == pastriesId);
        }

        public IEnumerable<Review>GetReviewsByPastriesId(int pastriesId)
        {
            throw new Exception("mockPastriesRepo implemt.");
        }
      
    }
}

