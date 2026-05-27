using UminekoWeb.Services;

namespace UminekoWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // IBookDataServiceが必要な時はDbBookDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IBookDataService, DbBookDataService>();

            // ICategoryDataServiceが必要な時はDbCategoryDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<ICategoryDataService, DbCategoryDataService>();

            // ILentHistoryDataServiceが必要な時はDbLentHistoryDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<ILentHistoryDataService,DbLentHistoryDataService>();

            // IMemberDataServiceが必要な時はDbMemberDataServiceを使うようDIコンテナに登録
            builder.Services.AddTransient<IMemberDataService,DbMemberDataService>();

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