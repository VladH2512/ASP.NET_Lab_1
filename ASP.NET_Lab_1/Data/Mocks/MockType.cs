using ASP.NET_Lab_1.Data.Interfaces;
using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_1.Data.Mocks
{
    public class MockType : IClothesType
    {
        public IEnumerable<Type> AllTypes
        {
            get
            {
                return new List<Type>
                {
                    new Type {Id = 1, TypeName = "T-Shirt"},
                    new Type {Id = 2, TypeName = "Jacket"},
                    new Type {Id = 3, TypeName = "Jeans"},
                    new Type {Id = 4, TypeName = "Dress"},
                    new Type {Id = 5, TypeName = "Socks"},
                    new Type {Id = 6, TypeName = "Boots"},
                    new Type {Id = 7, TypeName = "Cap"},
                    new Type {Id = 8, TypeName = "Shorts"},
                    new Type {Id = 9, TypeName = "Skirt"},
                };
            }
        }
    }
}
