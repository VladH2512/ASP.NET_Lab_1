using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_1.Data.Interfaces
{
    public interface IAllClothes
    {
        IEnumerable<Clothes> Clothes { get; }
        Clothes getObjectClothes(int clothId);
    }
}
