using JobPostManagement.Data;
using JobPostManagement.Helpers;
using JobPostManagement.Interfaces;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Services;
using JobPostManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddServiceExtensions(builder.Configuration);

// ✅ Add Session
builder.Services.AddSession();

var app = builder.Build();

// Seed Static Admin
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!context.Users.Any(u => u.Email == "admin@gmail.com"))
    {
        context.Users.Add(new User
        {
            Id = Guid.NewGuid().ToString(),
            Username = "Admin",
            Email = "admin@gmail.com",
            Password = "Admin@123",
            Role = Roles.Admin
        });

        context.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

// ✅ Enable Session BEFORE Authorization
app.UseSession();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
