using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using ShopCore.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ShopContext>(options =>
{
    options.UseMySql(conn, ServerVersion.AutoDetect(conn));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.Title = "ShopCore Api";
        options.Theme = ScalarTheme.BluePlanet;
        options.DefaultHttpClient = new(ScalarTarget.CSharp, ScalarClient.HttpClient);
        options.CustomCss = "";
        options.ShowSidebar = true;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
