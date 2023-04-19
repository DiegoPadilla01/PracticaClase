using Dapper.Contrib.Extensions;
using TecNM.Ecommerce.Api.DataAccess;
using TecNM.Ecommerce.Api.DataAccess.Interface;
using TecNM.Ecommerce.Api.Repositories;
using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Api.Services;
using TecNM.Ecommerce.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IProductCategoryRepository, InMemoryProductCategoryRepository>();
//builder.Services.AddSingleton<IProductCategoryRepository, ProductCategoryRepositories>();
//builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
//builder.Services.AddSingleton<IProviderRepository, InMemoryProviderRepository>();
builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepositories>();
builder.Services.AddScoped<IProductCategoryServices, ProductCategoryService>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepositories>();
builder.Services.AddScoped<ICategoryServices, CategoryService>();
builder.Services.AddScoped<IDbContext, DbContext>();

SqlMapperExtensions.TableNameMapper = entityType =>
{
    var name = entityType.ToString();
    if (name.Contains("TecNM.Ecommerce.Core.Entities."))
        name = name.Replace("TecNM.Ecommerce.Core.Entities.",  "");
    
    var letters = name.ToCharArray();
    letters[0] = char.ToUpper(letters[0]);
    return new string(letters);

};

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();