using ASP.NET_Lab_1.Data.Interfaces;
using ASP.NET_Lab_1.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_1.Data.Mocks
{
    public class MockColor : IClothesColor
    {
        public IEnumerable<Color> AllColors
        {
            get
            {
                return new List<Color>
                {
                    new Color {Id = 1, ColorName = "Blue"},
                    new Color {Id = 2, ColorName = "Green"},
                    new Color {Id = 3, ColorName = "Red"},
                    new Color {Id = 4, ColorName = "Yellow"},
                    new Color {Id = 5, ColorName = "Brown"},
                    new Color {Id = 6, ColorName = "Purple"},
                    new Color {Id = 7, ColorName = "Orange"},
                    new Color {Id = 8, ColorName = "Pink"},
                    new Color {Id = 9, ColorName = "Violet"},
                    new Color {Id = 10, ColorName = "Grey"},
                    new Color {Id = 11, ColorName = "Black"},
                    new Color {Id = 12, ColorName = "White"},
                    new Color {Id = 13, ColorName = "Colorful"},
                };
            }
        }
    }
}
