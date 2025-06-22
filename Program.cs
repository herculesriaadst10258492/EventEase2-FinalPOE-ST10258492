using Microsoft.EntityFrameworkCore;
using EventEase2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register ApplicationDbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Adds security headers in production
}

app.UseHttpsRedirection();   // Redirect HTTP to HTTPS
app.UseStaticFiles();        // ✅ Enables access to /wwwroot (e.g. Bootstrap, custom CSS, JS)
app.UseRouting();            // Routing setup
app.UseAuthorization();      // Handles [Authorize] attributes

// Define route pattern
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

