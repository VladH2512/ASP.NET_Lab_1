using ASP.NET_Lab_1.Data.Interfaces;
using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Lab_1.Data.Mocks
{
    public class MockClothes : IAllClothes
    {
        private readonly IClothesCategory _categoryClothes = new MockCategory();
        private readonly IClothesCompany _companyClothes = new MockCompany();
        private readonly IClothesType _typeClothes = new MockType();
        private readonly IClothesColor _colorClothes = new MockColor();

        public IEnumerable<Clothes> Clothes
        {
            get
            {
                return new List<Clothes>
                {
                    new Clothes {
                        Id = 1, 
                        Img = "https://sneakerstudio.com.ua/rus_pm_MUZHSKAIA-FUTBOLKA-adidas-Originals-Adicolor-Classics-3-Stripes-Tee-GN3495-37717_3.jpg",
                        CategoryId = 2, Category = _categoryClothes.AllCategories.ElementAt(1),
                        CompanyId = 1, Company = _companyClothes.AllCompanies.ElementAt(0),
                        TypeId = 1, Type = _typeClothes.AllTypes.ElementAt(0),
                        ColorId = 11, Color = _colorClothes.AllColors.ElementAt(10),
                        Price = 787,

                    },
                    new Clothes {
                        Id = 2,
                        Img = "https://evikakids.com/ru/1673/yubka-krasnaya-iz-plotnogo-riflenogo-khlopka.jpg",
                        CategoryId = 1, Category = _categoryClothes.AllCategories.ElementAt(0),
                        CompanyId = 6, Company = _companyClothes.AllCompanies.ElementAt(5),
                        TypeId = 9, Type = _typeClothes.AllTypes.ElementAt(8),
                        ColorId = 3, Color = _colorClothes.AllColors.ElementAt(2),
                        Price = 4200,

                    },
                    new Clothes {
                        Id = 3,
                        Img = "https://media2.symbol.ua/aio-images/e7/74/e7749d6aeb8bc577477dfb1bc4870bfe/e7a5b8c2-9378-468d-88e6-c473be2d804f.jpg",
                        CategoryId = 3, Category = _categoryClothes.AllCategories.ElementAt(2),
                        CompanyId = 4, Company = _companyClothes.AllCompanies.ElementAt(3),
                        TypeId = 4, Type = _typeClothes.AllTypes.ElementAt(3),
                        ColorId = 11, Color = _colorClothes.AllColors.ElementAt(10),
                        Price = 51917,

                    },
                };
            }
        }

        public Clothes getObjectClothes(int clothId)
        {
            throw new System.NotImplementedException();
        }
    }
}
