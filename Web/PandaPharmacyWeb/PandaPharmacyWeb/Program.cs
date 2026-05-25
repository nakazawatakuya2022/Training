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

            // ICategoryDataServiceが必要な時はDbCategoryDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<ICategoryDataService, DbCategoryDataService>();

            // IOrderDataServiceが必要な時はDbOrderDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IOrderDataService, DbOrderDataService>();

            // セッションの機能を設定（有効期限を30分にする例）
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

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

            // セッションの利用を開始    
            app.UseSession();

            app.MapRazorPages();

            app.Run();
        }
    }
}
