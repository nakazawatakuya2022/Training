using YokoamiPetWeb.Services;

namespace YokoamiPetWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // DIコンテナに、IHistoryDataServiceを実装したDbHistoryDataServiceクラスを登録
            builder.Services.AddTransient<IHistoryDataService, DbHistoryDataService>();

            // DIコンテナに、IServiceDataServiceを実装したDbServiceDataServiceクラスを登録
            builder.Services.AddTransient<IServiceDataService, DbServiceDataService>();

            // DIコンテナに、IPetServicesを実装したDbPetServicesクラスを登録
            builder.Services.AddTransient<IPetServices, DbPetServices>();

            // Add services to the container.
            builder.Services.AddRazorPages();

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
