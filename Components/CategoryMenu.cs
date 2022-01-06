using Microsoft.AspNetCore.Mvc;
using PoloPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloPieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var Categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);

            return View(Categories);
        }
    }
}
