using Microsoft.EntityFrameworkCore;
using Npgsql;
using Aztrowebaplication.Repositories;
using Aztrowebaplication.Data;
using Aztrowebaplication.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));
// Add services to the container.

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserServices>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

//var conection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=*y#yDm^Jdv@L-;Database=aztrodb_tareatres");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
