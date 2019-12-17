using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test__Backery.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDdContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDdContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDdContext.Categories;
    }
}
