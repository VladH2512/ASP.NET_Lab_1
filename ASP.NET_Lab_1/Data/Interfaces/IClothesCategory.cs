using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_1.Data.Interfaces
{
    public interface IClothesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
