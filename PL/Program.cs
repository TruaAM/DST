using Data.Context;
using Data.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
/* using (DataContext db = new DataContext()) // Not work
{
    
    var infos = db.MainInfos.ToList();
    Console.WriteLine("������ ��'����:");
    foreach (MainInfo u in infos)
    {
        Console.WriteLine($"{u.Quote}.{u.Author}");
    }
} */

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");;

app.Run();


