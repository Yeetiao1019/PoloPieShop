using PoloPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public AppDbContext _appDbContext { get; }

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories 
        {
            get 
            {
                return _appDbContext.Categories;
            }
        }
    }
}
