using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test__Backery.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
           new List<Category>
           {
                new Category{CategoryId=1, CategoryName="Bread", Description="Lovely bread made with love"},
                new Category{CategoryId=2, CategoryName="Cakes", Description="Delicious cakes for every day"},
                new Category{CategoryId=3, CategoryName="Cakes for special occasions", Description="Get ready to PARTY!!!"}
           };
    }
}
