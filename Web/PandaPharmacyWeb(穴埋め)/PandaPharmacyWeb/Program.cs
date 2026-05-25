using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // IProductDataServiceが必要な時はDbProductDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IProductDataService, DbProductDataService>();
            // DbProductDataServiceの代わりにMockProductDataServiceを使いたい時はこう書く
            // builder.Services.AddTransient<IProductDataService, MockProductDataService>();

            // ICategoryDataServiceが必要な時はDbCategoryDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<ICategoryDataService, DbCategoryDataService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
