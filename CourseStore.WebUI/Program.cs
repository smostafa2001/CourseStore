using CourseStore.BusinussLogic;
using CourseStore.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CourseStoreDbContext>(option=> option.UseSqlServer("SERVER=.; INITIAL CATALOG=CourseStoreDb; USER ID=sa; PASSWORD=1;"));
builder.Services.AddScoped<CourseServices>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
