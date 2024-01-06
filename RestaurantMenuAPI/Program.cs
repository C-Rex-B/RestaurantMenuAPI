using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RestaurantMenuAPI.Models;
using RestaurantMenuAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<DishStoreDatabaseSettings>(
    builder.Configuration.GetSection(nameof(DishStoreDatabaseSettings)));

builder.Services.AddSingleton<IDishStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<DishStoreDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("DishStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IDishService, DishService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
