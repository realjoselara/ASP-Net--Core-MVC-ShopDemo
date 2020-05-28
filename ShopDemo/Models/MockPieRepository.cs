using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDemo.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Delicious Pie"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get;  }

        public Pie GetPieByIdI(int PieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == PieId);
        }
    }
}
