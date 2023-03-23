using ASP.NET_Lab_1.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Lab_1.Data.Controllers
{
    public class ClothesController: Controller
    {
        private readonly IAllClothes _allClothes;
        private readonly IClothesColor _allColor;

        public ClothesController(IAllClothes allClothes, IClothesColor allColor)
        {
            _allClothes = allClothes;
            _allColor = allColor;
        }

        public ViewResult List()
        {
            var clothes = _allClothes.Clothes;
            return View(clothes);
        }
    }
}
