using Microsoft.AspNetCore.Mvc;
using PoloPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoloPieShop.ViewModels;

namespace PoloPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        //public IActionResult List()
        //{
        //    PieListViewModel PieListViewModel = new PieListViewModel();
        //    PieListViewModel.Pies = _pieRepository.AllPies;
        //    PieListViewModel.CurrentCategory = "吃了會幸福的派";

        //    return View(PieListViewModel);
        //}

        public IActionResult List(string category)
        {
            IEnumerable<Pie> Pies;
            string CurrentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                Pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                CurrentCategory = "所有類型";
            }
            else
            {
                Pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category).OrderBy(p => p.PieId);
                CurrentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new PieListViewModel
            {
                Pies = Pies,
                CurrentCategory = CurrentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
