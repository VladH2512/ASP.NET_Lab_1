using ASP.NET_Lab_1.Data.Interfaces;
using ASP.NET_Lab_1.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;


namespace ASP.NET_Lab_1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllClothes, MockClothes>();
            services.AddTransient<IClothesCategory, MockCategory>();
            services.AddTransient<IClothesType, MockType>();
            services.AddTransient<IClothesCompany, MockCompany>();
            services.AddTransient<IClothesColor, MockColor>();

            services.AddMvc(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //відображення помилок
            app.UseDeveloperExceptionPage();

            app.UseStatusCodePages();//відображення коду сторінки

            //для відображення різних файлів, таких як зображення, css-файли та інше
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute(); //для маршрутизації за замовчування
        }
    }
}
