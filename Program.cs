using HolidayApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC services
builder.Services.AddControllersWithViews();

// Database connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Middleware
app.UseStaticFiles();

app.UseRouting();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Holiday}/{action=Index}/{id?}");

app.Run();