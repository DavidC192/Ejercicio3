using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

var conection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=*y#yDm^Jdv@L-;Database=aztrodb_tareatres");
try
{
    conection.Open();
    Console.WriteLine("Conected to database");
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
