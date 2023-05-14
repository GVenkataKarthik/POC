using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using POC.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
// once this line is written, go to tools - NuGet Package Manager - Package Manager Console - write a command "update-database" (it creates a new db in the sql server)
// this step will create the database from VS using EF core which is installed using NuGet Package instead of opening SQL Server and create it manually

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
