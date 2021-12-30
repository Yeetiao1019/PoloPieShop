using Microsoft.AspNetCore.Mvc;
using PoloPieShop.Model;
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

        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PieListViewModel PieListViewModel = new PieListViewModel();
            PieListViewModel.Pies = _pieRepository.AllPies;
            PieListViewModel.CurrentCategory = "吃了會幸福的派";

            return View(PieListViewModel);
        }
    }
}
