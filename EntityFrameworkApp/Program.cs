using EntityFrameworkApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//appsettingsten dosyayý çekebilmemiz için bunu koyduk. 
var configuration = builder.Configuration;


//Burda bunu ekleyebilmek için sqlserver entity framework den eklendi nuget packet

builder.Services.AddDbContext<EfDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("Default"))
);





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
