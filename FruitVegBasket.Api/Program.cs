using FruitVegBasket.Api.Constants;
using FruitVegBasket.Api.Data;
using FruitVegBasket.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => 
            options.UseSqlServer(
                builder.Configuration.GetConnectionString(DatabaseConstants.GroceryConnectionStringKey)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var mastersGroup = app.MapGroup("/masters")
                    .AllowAnonymous();

mastersGroup.MapGet("/categories", async (DataContext context) =>
    TypedResults.Ok(await context.Categories
    .AsNoTracking()
    .ToArrayAsync()
    )
);
mastersGroup.MapGet("/offers", async (DataContext context) =>
    TypedResults.Ok(await context.Offers
    .AsNoTracking()
    .ToArrayAsync()
    )
);

app.MapGet("/popular-products", async (DataContext context, int? count) =>
{
    if (!count.HasValue || count <= 0)
        count = 6;

    var randomProducts = await context.Products
                            .AsNoTracking()
                            .OrderBy(p => Guid.NewGuid())
                            .Take(count.Value)
                            .Select(Product.DtoSelector)
                            .ToArrayAsync();
    return TypedResults.Ok(randomProducts);
});

app.Run("https://localhost:12345");

