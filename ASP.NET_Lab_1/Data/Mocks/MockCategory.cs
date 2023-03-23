using ASP.NET_Lab_1.Data.Interfaces;
using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_1.Data.Mocks
{
    public class MockCategory : IClothesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {Id = 1, CategoryName = "Childish"},
                    new Category {Id = 2, CategoryName = "Male"},
                    new Category {Id = 3, CategoryName = "Female"},
                };
            }
        }
    }
}
