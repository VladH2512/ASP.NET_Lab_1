using ASP.NET_Lab_1.Data.Interfaces;
using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_1.Data.Mocks
{
    public class MockCompany : IClothesCompany
    {
        public IEnumerable<Company> AllCompanies
        {
            get
            {
                return new List<Company>
                {
                    new Company {Id = 1, Name = "Adidas"},
                    new Company {Id = 2, Name = "Gucci"},
                    new Company {Id = 3, Name = "Louis Vuitton"},
                    new Company {Id = 4, Name = "Prada"},
                    new Company {Id = 5, Name = "Dior"},
                    new Company {Id = 6, Name = "Evika Kids"},
                    new Company {Id = 7, Name = "Reporter Young"},
                };
            }
        }
    }
}
