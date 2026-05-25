using HimawariRentalWeb.Services;

namespace HimawariRentalWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // IRentalItemDataServiceが必要な時はDbRentalItemDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IRentalItemDataService, DbRentalItemDataService>();

            // ICategoryDataServiceが必要な時はDbCategoryDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<ICategoryDataService, DbCategoryDataService>();

            // IRentalHistoryDataServiceが必要な時はDbRentalHistoryDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IRentalHistoryDataService, DbRentalHistoryDataService>();

            // ICustomerDataServiceが必要な時はDbCustomerDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<ICustomerDataService, DbCustomerDataService>();

            // IUserAccountDataServiceが必要な時はDbUserAccountDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IUserAccountDataService, DbUserAccountDataService>();

            // IRankingDataServiceが必要な時はDbRankingRentalItemDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IRankingRentalItemDataService, DbRankingRentalItemDataService>();

            // セッションの機能を設定（有効期限を30分にする）
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
