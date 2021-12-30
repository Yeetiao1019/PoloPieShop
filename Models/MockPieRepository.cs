using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloPieShop.Model
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie{ PieId =1 , Name = "水果派",ShortDescription="有水果", LongDescription="這個派有水果" ,  Price = 10, CategoryId = 1, InStock = true, IsPieOfTheWeek = true,  AllergyInformation = "無",Category=_categoryRepository.AllCategories.ToList()[0], ImageThumbnailUrl="https://www.simplyrecipes.com/thmb/k_v3nBZyFLSjp7qPjNm6DC5NSBw=/3297x3297/smart/filters:no_upscale()/Simply-Recipes-Lattice-Pie-Crust-LEAD-6-f5f3bc7e48d24fd7a10e2b60b0b07632.jpg"},
            new Pie{ PieId =2 , Name = "肉肉派",ShortDescription="有肉肉", LongDescription="這個派有肉肉" ,  Price = 15, CategoryId = 2, InStock = true, IsPieOfTheWeek = true,  AllergyInformation = "無",Category=_categoryRepository.AllCategories.ToList()[1], ImageThumbnailUrl="https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/E650E954-248F-4CF5-91C0-A739B2D24704/Derivates/8CFD4535-CEC4-478E-AD34-9C4AD56F4B81.jpg"},
            new Pie{ PieId =3 , Name = "少糖派",ShortDescription="沒有奶油", LongDescription="這個派沒有奶油" ,  Price = 8, CategoryId = 3, InStock = true, IsPieOfTheWeek = true,  AllergyInformation = "無",Category=_categoryRepository.AllCategories.ToList()[2], ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Cherry-Pie-Slice.jpg/640px-Cherry-Pie-Slice.jpg"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
