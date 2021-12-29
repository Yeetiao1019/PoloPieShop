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
            new Pie{ PieId =1 , Name = "水果派",ShortDescription="有水果", LongDescription="這個派有水果" ,  Price = 10, CategoryId = 1, InStock = true, IsPieOfTheWeek = true,  AllergyInformation = "無"},
            new Pie{ PieId =2 , Name = "肉肉派",ShortDescription="有肉肉", LongDescription="這個派有肉肉" ,  Price = 15, CategoryId = 2, InStock = true, IsPieOfTheWeek = true,  AllergyInformation = "無"},
            new Pie{ PieId =3 , Name = "少糖派",ShortDescription="沒有奶油", LongDescription="這個派沒有奶油" ,  Price = 8, CategoryId = 3, InStock = true, IsPieOfTheWeek = true,  AllergyInformation = "無"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
