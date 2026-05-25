namespace WebSampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // セッションの機能を設定（有効期限を1分にする例）
            // この部分を記載しない場合、デフォルトの有効期限は20分
            builder.Services.AddSession(options =>
            {
                // ()の中がセッションの有効期限
                options.IdleTimeout = TimeSpan.FromMinutes(1);
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
