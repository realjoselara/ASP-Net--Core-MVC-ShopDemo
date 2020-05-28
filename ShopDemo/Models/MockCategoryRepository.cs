using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDemo.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategory =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="Delicious fruit pie" },
                new Category{CategoryId=2, CategoryName="Dulce de Leche", Description="Wow Dulce de leche pie" }
            };
    }
}
