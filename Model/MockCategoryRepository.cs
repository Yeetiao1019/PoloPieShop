using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloPieShop.Model
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{ CategoryId = 1, CategoryName= "甜派",Description="甜甜的"},
            new Category{ CategoryId = 2, CategoryName= "鹹派",Description="鹹鹹的"},
            new Category{ CategoryId = 1, CategoryName= "減糖派",Description="不太甜的"}
        };
    }
}
