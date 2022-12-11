using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASP.NET_Core_MVC_Application.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ASPNET_Core_MVC_ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ASPNET_Core_MVC_ApplicationContext") ?? throw new InvalidOperationException("Connection string 'ASPNET_Core_MVC_ApplicationContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
