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

        public IActionResult List()
        {
            PieListViewModel PieListViewModel = new PieListViewModel();
            PieListViewModel.Pies = _pieRepository.AllPies;
            PieListViewModel.CurrentCategory = "吃了會幸福的派";

            return View(PieListViewModel);
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
